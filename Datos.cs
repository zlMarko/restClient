using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;
namespace AeronauticaCliente
{
    class Datos
    {
        public dynamic GetDatos(string url)
        {
            WebClient wc = new WebClient();

            var datos = wc.DownloadString(url);

            var data = JsonConvert.DeserializeObject<dynamic>(datos);


            return data;
        }

        

    }
}
