using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Persona
    {
        public int DNI { get; }
        public string Nombre { get; set; }

        public Persona (int dni, string nombre)
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }


    }
}
