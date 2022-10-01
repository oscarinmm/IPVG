using IPVG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado = new Empleado();

            Console.WriteLine("Ingrese RUT:");
            empleado.Rut = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nombre:");
            empleado.Nombre = Console.ReadLine();

            
            Console.WriteLine("Ingrese Apellido:");
            empleado.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese Telefono:");
            empleado.Telefono = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Cargo:");
            empleado.Cargo = Console.ReadLine();
            
            Console.WriteLine("Ingrese Sucursal:");
            empleado.Sucursal = Console.ReadLine();

            Console.WriteLine("Ingrese Jefe:");
            empleado.Jefe = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("El trabajador es: ");
            Console.WriteLine();
            Console.WriteLine(""+empleado.Nombre + " " + empleado.Apellido );
            Console.WriteLine();
            Console.WriteLine("Telefono: " + empleado.Telefono );
            Console.WriteLine();
            Console.WriteLine("Cargo: " +empleado.Cargo);
            Console.WriteLine();
            Console.WriteLine("Sucursal: " +empleado.Sucursal);
            Console.WriteLine();
            Console.WriteLine("Su actual Jefe es: " + empleado.Jefe); 




            Console.Read();




        }
    }
}
