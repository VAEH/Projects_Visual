using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.cs
{
    class CCuentaCorriente : CCuenta, IFecha
    {
        //atributos
        private static double cuotaMantenimiento;


        //metodos

        public CCuentaCorriente() { }

        public CCuentaCorriente(string nom, string cue, double sal, double tipo, double mant) : base(nom, cue, sal,tipo)
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

       
        public new void reintegro(double cantidad)// new es de la version derivada 
        {
            double saldo = estado();
            double tipoDeinteres = obtenerTipoDeInteres();

            if (tipoDeinteres >= 4.5)
            {
                if (saldo - cantidad < 5000)
                {
                    System.Console.WriteLine("Error: no dispone de esa cantidad");
                    return;
                }
                base.reintegro(cantidad);//metodo reintegro de la clase  base, superclase
            }
        }

        public override double intereses()
        {
            System.Console.WriteLine("CCuentaCorriente.intereses");
            double interesesProducidos = 5.5;
            if (Dia() != 1) return 5.5;
            
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
