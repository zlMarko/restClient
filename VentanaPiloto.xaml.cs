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

using MahApps.Metro.Controls;

namespace AeronauticaCliente
{
    /// <summary>
    /// Interaction logic for VentanaPiloto.xaml
    /// </summary>
    public partial class VentanaPiloto : MetroWindow
    {
        public VentanaPiloto()
        {
            InitializeComponent();
        }
         public string rutPiloto = string.Empty;

        Datos datos = new Datos();
        private void Consulta_Horas_Vuelo(object sender, RoutedEventArgs e)
        {

            string url = "http://192.168.0.4:8000/api-views/piloto/" + rutPiloto;

            HoraVueloA.Content = datos.GetDatos(url).horas_vuelo_A;
            HoraVueloE.Content = datos.GetDatos(url).horas_vuelos_E;
        }

        private void Consulta_Aeronaves_Disponibles(object sender, RoutedEventArgs e)
        {

            string url = "http://192.168.0.4:8000/api-views/aeronave-disponible/";
            
            GridAeronaves.ItemsSource = datos.GetDatos(url);

        }

        private void Registra_vuelo(object sender, RoutedEventArgs e)
        {
            RegistroVuelo RV = new RegistroVuelo();
            RV.PilotoText.Text = rutPiloto;
            RV.PilotoText.IsEnabled = false;
            RV.ShowDialog();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            main.Show();
            this.Close();
        }
    }
}
