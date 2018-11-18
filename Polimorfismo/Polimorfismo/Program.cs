using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoAsalariado empleadoAsalariado =new EmpleadoAsalariado("John", "Smith", "111-11-1111", 800.00M);

            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras("Karen", "Price", "222-22-2222", 16.75M, 40.0M);

           

           System. Console.WriteLine("Empleados procesados en forma individual:\n");

           System.  Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoAsalariado, "ingresos", empleadoAsalariado.Ingresos());

             System.Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoPorHoras, "ingresos", empleadoPorHoras.Ingresos());

            



             Empleado[] empleados = new Empleado[2];

             empleados[0] = empleadoAsalariado;

              empleados[1] = empleadoPorHoras;

            System.Console.WriteLine("Empleados procesados en forma polimórfica:\n");

            



               foreach (Empleado empleadoActual in empleados)

                 {

                 System.Console.WriteLine(empleadoActual); 
        }

            for (int j = 0; j < empleados.Length; j++)

                 System.Console.WriteLine("Empleado {0} es un {1}", j,

                 empleados[j].GetType());

            } 

  
}
}
