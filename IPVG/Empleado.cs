using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class Empleado
    {
        public int Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Cargo { get; set; }
        public string Sucursal { get; set; }
        public string Jefe { get; set; }

        public Empleado(int rut, string nombre, string apellido, string direccion, int telefono, string cargo, string sucursal, string jefe)
        {
            Rut = rut;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Cargo = cargo;
            Sucursal = sucursal;
            Jefe = jefe;
        }

        public Empleado()
        {

        }
    }


}
