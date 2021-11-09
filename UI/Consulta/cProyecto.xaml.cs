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

namespace P2_AP1_Stephany_2018_0654.UI.Consulta
{
    /// <summary>
    /// Interaction logic for cProyecto.xaml
    /// </summary>
    public partial class cProyecto : Window
    {
        public cProyecto()
        {
            InitializeComponent();
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Proyecto>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //ProyectoId
                        int.TryParse(CriterioTextBox.Text, out int TareasId);
                        listado = ProyectoBLL.GetList(a => a.ProyectoId == TareasId);
                        break;

                    case 1: //DEscripcion
                        listado = ProyectoBLL.GetList(a => a.DescripcionProyecto.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = ProyectoBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = listado.Where(c => c.Fecha.Date >= DesdeDataPicker.SelectedDate).ToList();

            if (HastaDatePicker.SelectedDate != null)
                listado = listado.Where(c => c.Fecha.Date <= HastaDatePicker.SelectedDate).ToList();

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
