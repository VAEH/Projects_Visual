using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion
{
    public abstract class Persona
    {

        public string Nombre { get; set; }

        public abstract string Saludar();
    }

    public class Alumno : Persona
    {
        public Alumno(string nombre)
        {
            this.Nombre = nombre;
        }
        public override string Saludar()
        {
            string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un alumno";
            return saludo;
        }
    }
    public class Empleado : Persona
    {
        public Empleado(string nombre)
        {
            this.Nombre = nombre;
        }
        public override string Saludar()
        {
            string saludo = "Hola, mi nombre es " + this.Nombre + " y soy un empleado";
            return saludo;
        }
    }
}
