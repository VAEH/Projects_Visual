using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.cs
{
    class CCuenta
    {
        //cuerpo de la clase : atributos y metodos

        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInteres;

        public CCuenta() { }

        public CCuenta(string nom, string cue, double sal, double tipo)
        {
            //System.Console.WriteLine("Nombre:");
            asignarNombre(nom);
         //  System.Console.WriteLine("Cuenta:");
            asignarCuenta(cue);
            ingreso(sal);
            asignarTipoDeInteres(tipo);
        }

        //metodo responde a la accion de de ingresar una cantidad en una cuenta
        public void ingreso(double cantidad)
        {
            if (cantidad <0)
            {
                System.Console.WriteLine("Error: cantidad Negativa");

            }

            saldo = saldo + cantidad;
        }

        // obtiene o asigna el nombre de un cliente a una cuenta
         
        public void asignarNombre(string nom)
        {
     
                if (nom.Length == 0)
                {
                    System.Console.WriteLine("Error: cadena vacia");
                    return;
                   
                }
                nombre = nom;
        }

        public string obtenernombre()

        {
            System.Console.WriteLine("Nombre:");
            return this.nombre;
        }

        public void asignarCuenta(string cue)
        {
   
                if (cue.Length == 0)
                {
                    System.Console.WriteLine("Erros: cuenta no valida");
                    return;
                }
                cuenta = cue;
  
        }
        public string obtenerCuenta()
        {
            System.Console.WriteLine("Cuenta:");
            return cuenta;
        }

        public double estado()
        {

           // System.Console.WriteLine("Estado:");
            return saldo;
        }

        //obtiene el saldo de la cuenta

        public double Saldo
        {
            
            get { return saldo; }
        }

       public void reintegro(double cantidad)
        {
            if(saldo - cantidad < 0)
            {
                System.Console.WriteLine("Error: no disponde de saldo");
                return;
            }
            saldo = saldo - cantidad;
        }

        public void asignarTipoDeInteres(double tipo)
      
        {

                if(tipo < 0)
                {
                    System.Console.WriteLine("Erroe: tipo no valido");
                    return;
                }
                tipoDeInteres = tipo;   
        }

        public double obtenerTipoDeInteres()
        {
            return tipoDeInteres;
        }

        public virtual double intereses()
        {
            System.Console.WriteLine("CCuenta.intereses");
            double interesesProducidos = 0.0;
            return interesesProducidos;
        }

       /* public interface IFecha
        {
            int Dia();
            int Mes();
            int Año();
        }*/

    }
}
