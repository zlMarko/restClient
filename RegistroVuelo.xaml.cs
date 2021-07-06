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

using System.Net;
using System.IO;
using MahApps.Metro.Controls;
using Newtonsoft.Json;
using RestSharp;
using MahApps.Metro.Controls.Dialogs;

namespace AeronauticaCliente
{
    /// <summary>
    /// Interaction logic for RegistroVuelo.xaml
    /// </summary>
    public partial class RegistroVuelo : MetroWindow
    {
        public RegistroVuelo()
        {
            InitializeComponent();
        }
   
        private void Limpiar_campos()
        {
            
            CopilotoText.Text = string.Empty;
            Condicion_Vuelo.SelectedIndex = -1;
            Piloto_Horas_Text.Text = string.Empty;
            Copiloto_Horas_Text.Text = string.Empty;
            Piloto_Horas_Text.Text = string.Empty;
            OrigenText.Text = string.Empty;
            DestinoText.Text = string.Empty;
            MisionCompletaCheckBox.IsChecked = false;
            AeronaveText.Text = string.Empty;

        }

        private void LimpiarCampos(object sender, RoutedEventArgs e)
        {
            Limpiar_campos();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private async void RegistrarVuelo_Click(object sender, RoutedEventArgs e)
        {
            bool mision = true;
            if (MisionCompletaCheckBox.IsChecked == false)
            {
                mision = false;
            }

            
            Vuelo vuelo = new Vuelo()
                {
                    piloto = PilotoText.Text,
                    copiloto = CopilotoText.Text,
                    condicion_vuelo = Condicion_Vuelo.Text,
                    duracion_vuelo_p = int.Parse(Piloto_Horas_Text.Text),
                    duracion_vuelo_c = int.Parse(Copiloto_Horas_Text.Text),
                    duracion_vuelo_total = int.Parse(Piloto_Horas_Text.Text) + int.Parse(Copiloto_Horas_Text.Text),
                    origen = OrigenText.Text,
                    destino = DestinoText.Text,
                    mision_completada = mision,
                    aeronave = AeronaveText.Text
                };


                string url = "http://192.168.0.4:8000/api-viewsets/vuelos/";
                string result = string.Empty;

                var client = new RestClient(url);
                var request = new RestRequest();

                var body = JsonConvert.SerializeObject(vuelo, Formatting.Indented);

                request.AddJsonBody(body);

                var response = client.Post(request);

                await this.ShowMessageAsync("Atención!!", "Vuelo registrado");
                Limpiar_campos();
            
            
            


        }

        
    }
}
