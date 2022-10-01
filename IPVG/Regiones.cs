using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    internal class Regiones
    {
        public int id_region { get; set; }
        public string nombre_reg { get; set; }

       

        public Regiones(int id_region, string nombre_reg)
        {
            this.id_region = id_region;
            this.nombre_reg = nombre_reg;
        }

        public Regiones()
        {

        }
    }
}
