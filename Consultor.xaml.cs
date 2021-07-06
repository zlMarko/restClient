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

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using RestSharp;
using Newtonsoft.Json;

namespace AeronauticaCliente
{
    /// <summary>
    /// Interaction logic for Consultor.xaml
    /// </summary>
    public partial class Consultor : MetroWindow
    {
        public Consultor()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            matriculaAeronave.Text = string.Empty;
            detalleMantencion.Text = string.Empty;
            tecnicoEncargado.Text = string.Empty;
            horasVueloA.Text = string.Empty;
        }

        private async void ReporteBoton_Click(object sender, RoutedEventArgs e)
        {
            

            try
            {
                ReporteBoton.Visibility = Visibility.Hidden;

                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "reporte DGAC");
                }

                Reporte reporte = new Reporte()
                {
                    aeronave = matriculaAeronave.Text,
                    detalle_mantencion = detalleMantencion.Text,
                    encargado_mantenimiento = tecnicoEncargado.Text,
                    fecha_mantencion = fechaMantenimiento.DisplayDate.ToString("yyyy-MM-dd"),
                    horas_vuelo = int.Parse(horasVueloA.Text),


                };
                string url = "http://192.168.0.4:8000/api-viewsets/reporte/";
                string result = string.Empty;

                var client = new RestClient(url);
                var request = new RestRequest();

                var body = JsonConvert.SerializeObject(reporte, Formatting.Indented);
                
                request.AddJsonBody(body);

                var response = client.Post(request);

                await this.ShowMessageAsync("Atención!!", "Reporte registrado");
                limpiarCampos();

            }
            finally
            {
                ReporteBoton.Visibility = Visibility.Visible;
            }
            
        }

        
    }
}
