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

//project_libraries
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Security.Cryptography;

namespace AeronauticaCliente
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Datos datos = new Datos();
        public static string GetSHA1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString().ToUpper();
        }


        



        private async void LoginPiloto(object sender, RoutedEventArgs e)
        {                    
            try
            {
                if (TextBoxUsuario.Text == string.Empty)
                {
                    await this.ShowMessageAsync("Atención!!", "Rut no puede estar vacio");
                }
                else if (TextBoxPassword.Password == string.Empty)
                {
                    await this.ShowMessageAsync("Atención!!", "contraseña no puede estar vacio");
                }
                else
                {
                    
                    
                    string urlPilotos = "http://192.168.0.4:8000/api-views/piloto/";
                    
                    
                    string filtro = urlPilotos + TextBoxUsuario.Text;
                   
                    string rut = datos.GetDatos(filtro).rut;
                    string password = datos.GetDatos(filtro).password;
                    if ((TextBoxUsuario.Text == rut) && (GetSHA1(TextBoxPassword.Password) == password))
                    {
                        VentanaPiloto vp = new VentanaPiloto();

                        vp.rutPiloto = datos.GetDatos(filtro).rut;
                        vp.NombrePiloto.Content = datos.GetDatos(filtro).nombre;
                        vp.ApellidoPiloto.Content = datos.GetDatos(filtro).apellido;
                        vp.Show();
                        this.Close();
                    }
                    else 
                    
                    {
                       
                        await this.ShowMessageAsync("Atención!!","La contraseña es incorrecta!");
                    }
                      

                }
            }
            catch (Exception)
            {
                try
                {
                    if (TextBoxUsuario.Text == string.Empty)
                    {
                        await this.ShowMessageAsync("Atención!!", "Rut no puede estar vacio");
                    }
                    else if (TextBoxPassword.Password == string.Empty)
                    {
                        await this.ShowMessageAsync("Atención!!", "contraseña no puede estar vacio");
                    }
                    else
                    {


                        string urlConsultores = "http://192.168.0.4:8000/api-views/consultor/";


                        string filtro = urlConsultores + TextBoxUsuario.Text;

                        string rut = datos.GetDatos(filtro).rut;
                        string password = datos.GetDatos(filtro).password;
                        if ((TextBoxUsuario.Text == rut) && (GetSHA1(TextBoxPassword.Password) == password))
                        {
                            Consultor c = new Consultor();

                            c.NombreConsultor.Content = datos.GetDatos(filtro).nombre;
                            c.ApellidoConsultor.Content = datos.GetDatos(filtro).apellido;
                            c.Show();
                            this.Close();
                        }
                        else

                        {
                            await this.ShowMessageAsync("Atención!!", "La contraseña es incorrecta!");
                        }

                    }
                }
                catch (Exception)
                {
                    await this.ShowMessageAsync("Atención!!", "El Rut ingresado no se encuentra registrado en la base de datos!!");
                }                
                    
            }
            
        }
        
    }
}
