using P2_AP1_Stephany_2018_0654.UI.Consulta;
using P2_AP1_Stephany_2018_0654.UI.Registro;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P2_AP1_Stephany_2018_0654
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProyectoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProyecto proyecto = new rProyecto();
            proyecto.Show();
        }

        private void ProyectosConsultasItem_Click(object sender, RoutedEventArgs e)
        {
            cProyecto cProyecto = new cProyecto();
            cProyecto.Show();
        }

        private void TareaConsultasItem_Click(object sender, RoutedEventArgs e)
        {
            cTareas tarea = new cTareas();
            tarea.Show();
        }
    }
}
