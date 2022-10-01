using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class Sucursales
    {
        public int cod_sucursal { get; set; }
        public string nombre_suc { get; set; }

        public Departamento departamento { get; set; }

        public Sucursales(int cod_sucursal, string nombre_suc, Departamento departamento)
        {
            this.cod_sucursal = cod_sucursal;
            this.nombre_suc = nombre_suc;
            this.departamento = departamento;
        }

        public Sucursales()
        {
        }
    }
}
