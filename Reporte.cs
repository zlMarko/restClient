using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeronauticaCliente
{
    public class Reporte
    {

        public string fecha_mantencion { get; set; }
        public string detalle_mantencion { get; set; }
        public string encargado_mantenimiento { get; set; }
        public int horas_vuelo { get; set; }
        public string aeronave { get; set; }
    }
}
