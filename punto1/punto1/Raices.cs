using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
    class Raices
    {
        private double ax, bx, cx;

            public Raices()
        {

        }

        public Raices(int a, int b, int c)
        {
            ax = a;
            bx = b;
            cx = c;
        }

        public double getDiscriminante()
        {
            double d;
            if (ax < 0)
            {
                d = (Math.Pow(-1 * bx, 2) - (4 * (-1 * ax) * (-1 * cx)));

            }else
            { 
                d = (Math.Pow(bx, 2) - (4 * ax * cx));


            }return d;
        }

        public Boolean tieneRaices()
        {
            Boolean x;
            x = false;
            if(getDiscriminante() < 0)
            {
                x = false;
            }else if (getDiscriminante() >0)
            {
                x = true;

            } return x;

        }

        public Boolean tieneRaiz()
        {
            Boolean y;
            y = false;
            if (getDiscriminante() < 0)
            {
                y = false;
            }else if(getDiscriminante()==0)
            {
                y = true;
            }return y;
        }

        public double [] obtenerRaices()
        {
            double [] soluciones = new double [2];
            if (tieneRaices())
            {
                if (ax < 0)
                {
                    soluciones[0] = (bx + Math.Sqrt(Math.Pow(bx, 2) - (4 * (ax * -1) * (cx * -1)))) / (2*(ax*-1));
                    soluciones[1] = (bx - Math.Sqrt(Math.Pow(bx, 2) - (4 * (ax * -1) * (cx * -1)))) / (2 * (ax * -1));
                        

                }else 
                {
                    soluciones[0] = (((-1) * bx) + Math.Sqrt(Math.Pow(bx, 2) - (4 * ax * cx))) / (2 * ax);
                    soluciones[1] = (((1) * bx) - Math.Sqrt(Math.Pow(bx, 2) - (4 * ax * cx))) / (2 * ax);
                } 

            } return soluciones;


        }

        public double[] obtenerRaiz()
        {
            double[] solucion = new double[1];
            if (tieneRaiz())
            {
                if(ax<0)
                {
                    solucion[0] = (((-1) * (bx * -1)) + Math.Sqrt(Math.Pow((bx*-1), 2) - (4 * (ax * -1) * (cx * -1)))) / (2 * (ax * -1));

                }else
                {
                    solucion[0] = (((-1) * bx) + Math.Sqrt(Math.Pow(bx, 2) - (4 * ax * cx))) / (2 * ax);

                }
            }
            return solucion;

        }

        public void mostrarAlgebra()
        {
            double discriminante = getDiscriminante();
            if(discriminante == 0)
            {
                Console.WriteLine ("Error");

            }
            else
            {
                if (tieneRaices())
                {
                    Console.WriteLine("Discriminante es:" + discriminante);
                    double[] raizes = new double[2];
                    raizes = obtenerRaices();
                    if(raizes[0]<0 && raizes[1] <0)
                    {
                        raizes[0] = raizes[0] * -1;
                        raizes[1] = raizes[1] * -1;
                        Console.WriteLine("Factorizacion");
                        Console.WriteLine("(X - " + raizes[0].ToString("#.##") + ") (X - " + raizes[1].ToString("#.##") + ") = 0");


                    }else if(raizes[0]<0 &&raizes[1]>=0)
                    {
                        raizes[0] = raizes[0] * -1;
                        Console.WriteLine("factorizacion");
                        Console.WriteLine("(X - " + raizes[0].ToString("#.##") + ") (X + " + raizes[1].ToString("#.##") + ") = 0");
                    }else if(raizes[0]>=0 && raizes[1] < 0)
                    {
                        raizes[1] = raizes[1] * -1;
                        Console.WriteLine("factorizacion");
                        Console.WriteLine("(X + " + raizes[0].ToString("#.##") + ") (X - " + raizes[1].ToString("#.##") + ") = 0");
                    }else
                    {
                        Console.WriteLine("factorizacion");
                        Console.WriteLine("(X + " + raizes[0].ToString("#.##") + ") (X + " + raizes[1].ToString("#.##") + ") = 0");
                    }
                }
                else if (tieneRaiz())
                {
                    double[] raizes = new double[1];
                    raizes = obtenerRaiz();
                    if (raizes[0] < 0)
                    {
                        raizes[0] = raizes[0] * -1;
                        Console.WriteLine("factorizacion");
                        Console.WriteLine("(X - " + raizes[0] + ") = 0");

                    }
                    else
                    {
                        Console.WriteLine("factorizacion");
                        Console.WriteLine("(X + " + raizes[0] + ") = 0");
                    }
                }else
                {
                    Console.WriteLine("NO existe ");
                }
            }

        }


    }
}
