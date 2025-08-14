using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Servicio
    {
        //Persona[] persona = new Persona[1000]; asi tambien puede ser en forma de vector
        //int contador =0; si usamos vector hay que inicializar un contador 

        List<Persona> personas = new List<Persona>();

        public Servicio()
        {
        }
        public bool AgregarPersona(Persona nueva)
        {
            Persona existente = VerPersonaPorDNI(nueva.DNI);
            if (existente == null)
            {
                personas.Add(nueva);//Agrega

                //persona [contador] = nueva;
                //contador++;

                return true;
            }
            return false;

        }

        public int VerCantidadPersonas()
        {
            return personas.Count;//Count es una propiedad de la list
        }

        public Persona VerPersona(int n)
        {
            if (n >= 0 && n <= personas.Count)
            {
                return personas[n];
            }
            return null;
        }

        public Persona VerPersonaPorDNI(int dni)
        {
            int idx = -1;
            int n = 0;

            while (idx == -1)
            {
                if (personas[n].DNI == dni)
                {
                    idx = n;
                }
                n++;
            }

            if (idx > -1)
                return personas[idx];
            else
                return null;

        }

        public void EliminarPersona(Persona persona)
        {
            Persona existente = VerPersonaPorDNI(persona.DNI);

            if (existente != null)
            {
                personas.Remove(persona);//Elimina
            }
        }
    }
}
