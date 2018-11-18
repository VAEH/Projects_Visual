using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.cs
{
    class CCuentaAhorro: CCuenta, IFecha
    {
        // atributos
        private static double cuotaMantenimiento;


        


        //metodos

        public CCuentaAhorro() { }

        public CCuentaAhorro(string nom, string cue, double sal, double tipo, double mant) : base(nom, cue, sal,tipo) // se añade nuevos atributos y metodos a las subclase
                                                                                                                      //
        {
            
           asignarCuotaMantenimiento(mant); //invoca al constructo CCuenta //esto es, a la de la clase base

            
        }
        public static void asignarCuotaMantenimiento(double cantidad)
        {
            if (cantidad < 0)
                System.Console.WriteLine("Error: cantidad negativa");
            else
                cuotaMantenimiento = cantidad;
        }

        public static double obtenerCuotaManten()
        {
            return cuotaMantenimiento;
        }

        // redefine el metodo de la clase CCuenta, // obliga a disponer de un saldo positivo >1.500 con un interes=> 3,5
        
        public new void reintegro(double cantidad)
        {
            double saldo = estado();
            double tipoDeinteres = obtenerTipoDeInteres();

            if (tipoDeinteres >= 3.5)
            {
                if (saldo - cantidad < 1500)
                {
                    System.Console.WriteLine("Error: no dispone de esa cantidad");
                    return;
                }
                base.reintegro(cantidad);//metodo reintegro de la clase  base, superclase
            }
        }

        public override double intereses()
        {
            System.Console.WriteLine("CCuentaAhorro.intereses");
            double interesesProducidos = 0.0;
            if (Dia() != 1) return 0.0;
            
            return interesesProducidos;
        }

        public int Dia()
        {
            return DateTime.Now.Day;
        }

        public int Mes()
        {
            return DateTime.Now.Month;

        }

        public int Año()
        {
            return DateTime.Now.Year;
        }
    }
}
