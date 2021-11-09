using P2_AP1_Stephany_2018_0654.BLL;
using P2_AP1_Stephany_2018_0654.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P2_AP1_Stephany_2018_0654.UI.Registro
{
    /// <summary>
    /// Interaction logic for rProyecto.xaml
    /// </summary>
    public partial class rProyecto : Window
    {
        private Proyecto Proyecto = new Proyecto();
        public rProyecto()
        {
            InitializeComponent();
            Proyecto = new Proyecto();
            this.DataContext = this.Proyecto;
            LlenarCombo();
        }

        public void LlenarCombo()
        {
            TipoTareaComboBox.ItemsSource = TareasBLL.GetList(x => true);
            TipoTareaComboBox.SelectedValue = "TareasId";
            TipoTareaComboBox.DisplayMemberPath = "TipoTarea";

            if (TipoTareaComboBox.Items.Count > 0)
                TipoTareaComboBox.SelectedIndex = 0;
        }
        public void Cargar()
        {
            TiempoTotalTextBox.Text = this.Proyecto.Detalle.Sum(x => x.Tiempo).ToString("N2");
            this.DetalleDataGrid.ItemsSource = null;
            this.DetalleDataGrid.ItemsSource = this.Proyecto.Detalle;
            this.DataContext = null;
            this.DataContext = this.Proyecto;
        }
        public void Limpiar()
        {
            this.Proyecto = new Proyecto();
            LlenarCombo();
            Cargar();
        }
        private bool Validar()
        {
            bool Esvalido = true;
            if (DescricpionProyectoTextBox.Text.Length == 0)
            {
                Esvalido = false;
                MessageBox.Show("Debe Agregar una Descripcion al proyecto", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (TipoTareaComboBox.Items.Count <= 0)
            {
                Esvalido = false;
                MessageBox.Show("Debe Seleccionar una tarea", "Fallo", MessageBoxButton.OK,MessageBoxImage.Error);
            }
            if (RequerimientoTareaTextBox.Text.Length == 0)
            {
                Esvalido = false;
                MessageBox.Show("Debe Agregar un Requerimiento", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (TiempoTextBox.Text.Length ==0)
            {
                Esvalido = false;
                MessageBox.Show("Debe Agregar un Tiempo", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return Esvalido;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(ProyectoIdTextBox.Text, out int id);
            var Proyecto = ProyectoBLL.Buscar(id);

            if(Proyecto!=null)
            {
                this.Proyecto = Proyecto;
                Cargar();
            }
            else
            {
                this.Proyecto = new Proyecto();
                MessageBox.Show("Este proyecto no existe", "No existe", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(TiempoTextBox.Text, out int tiempo);

            var Tarea = (Tareas)TipoTareaComboBox.SelectedValue;

            this.Proyecto.Detalle.Add(new ProyectoDetalle
            {
                Id = 0,
                ProyectoId = this.Proyecto.ProyectoId,
                TareasId = Tarea.TareasId,
                TipoTarea = Tarea.TipoTarea,
                Requerimiento = RequerimientoTareaTextBox.Text,
                Tiempo = tiempo
            }) ;
            Cargar();
        }

        private void RemoverPermiso_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.SelectedIndex < 0)
                return;
            if (Proyecto.Detalle.Count <= 0)
                return;

            if(DetalleDataGrid.Items.Count>=1&&DetalleDataGrid.SelectedIndex <=DetalleDataGrid.Items.Count -1)
            {
                this.Proyecto.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private void NButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = ProyectoBLL.Guardar(this.Proyecto);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if(ProyectoBLL.Eliminar(this.Proyecto.ProyectoId))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
