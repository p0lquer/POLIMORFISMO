using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[5];
            empleados[0] = new DocenteFijo("Juan", "123", 1000, true);
            empleados[1] = new DocenteHora("Pedro", "456", 40);
            empleados[2] = new Administrativo("Maria", "789", 1200, true);
            empleados[3] = new Administrativo("Ana", "101", 1200, false);
            empleados[4] = new DocenteFijo("Luis", "121", 1000, false);
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine("Nombre: " + empleado.NombreApellido + " Salario: " + empleado.SalarioCalc());
            }
        }
    }
}
