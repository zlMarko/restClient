using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeronauticaCliente
{
    public class Vuelo
    {
        public string condicion_vuelo { get; set; }
        public int duracion_vuelo_p { get; set; }
        public int duracion_vuelo_c { get; set; }
        public int duracion_vuelo_total { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public bool mision_completada { get; set;  }
        public string copiloto { get; set; } 
        public string piloto { get; set; }
        public string aeronave { get; set; }

    }
}
