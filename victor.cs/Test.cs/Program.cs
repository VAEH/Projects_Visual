using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.cs
{
    class Program
    {
       public  static void Main(string[] args)
        {
            // CCuenta cuenta01 = new CCuenta();

            // CCuenta cuenta02 = new CCuenta("un nombre", "una cuenta", 6000, 2.5);

            /*CCuentaAhorro cuenta01 = new CCuentaAhorro();

            cuenta01.asignarNombre("un nombre");
            cuenta01.asignarCuenta("una cuenta");
            cuenta01.asignarTipoDeInteres(2.5);
            */

            CCuenta cliente;
            CCuentaAhorro cliente01;
            cliente01 = new CCuentaAhorro("Victor Echavarria", "20161243567", 10000, 3.5, 1.0);

            CCuentaCorriente cliente02;
            cliente02 = new CCuentaCorriente("Anibal Torres", "200012097654", 20000, 2.0, 1.0);

            //CCuentaAhorro cuenta01 = new CCuentaAhorro("Victor Echavarria", "20161208909", 10000, 3.5, 2.5); //
            //cobrar cuenta de mantenimiento
            //cuenta01.reintegro(CCuentaAhorro.obtenerCuotaManten());
            //cuenta01.ingreso(10000);
            //cuenta01.reintegro(18000);

            //double intereses;
            //cliente = cliente01;
            //intereses = cliente01.intereses();

            //cliente = cliente02;
            //intereses = cliente02.intereses();




            //cliente numero 1 cuenta de ahorros

            System.Console.WriteLine(cliente01.obtenernombre());
            System.Console.WriteLine(cliente01.obtenerCuenta());
            System.Console.WriteLine(cliente01.estado());
            System.Console.WriteLine(cliente01.obtenerTipoDeInteres());
            System.Console.WriteLine(cliente01.intereses());//interface
            System.Console.WriteLine();
            Console.ReadLine();


            //cliente numero 2, cuenta corriente 
            System.Console.WriteLine(cliente02.obtenernombre());
            System.Console.WriteLine(cliente02.obtenerCuenta());
            System.Console.WriteLine(cliente02.estado());
            System.Console.WriteLine(cliente02.obtenerTipoDeInteres());
            System.Console.WriteLine(cliente02.intereses());//interface



            Console.ReadKey();




            /*
             CCuenta[] cliente = new CCuenta[100];
             //se crean los objetos y se guardan las referencias en la matriz 

            cliente[0] = new CCuentaAhorro("Victor Echavarria", "225154141", 10000, 2.5, 3);

            cliente[1] = new CCuentaCorriente("Catalina Echavarria", "225154141", 10000, 2.5, 3);

            int i=0;

            while (cliente[i] != null){
            
            System.Console.Write(cliente[i].obtenerNombre() + ":");
            System.Console.Write(cliente[i].intereses());
            i+=1;
            }

             */
        }
    }
}
