using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class Departamento
    {
        public int cod_departamento { get; set; }
        public string nombre_depto { get; set; }

        public List<Empleado> empleado { get; set; }

        public Departamento(int cod_departamento, string nombre_depto, List<Empleado> empleado)
        {
            this.cod_departamento = cod_departamento;
            this.nombre_depto = nombre_depto;
            this.empleado = empleado;
        }

        public Departamento()
        {
                
        }
    }
}
