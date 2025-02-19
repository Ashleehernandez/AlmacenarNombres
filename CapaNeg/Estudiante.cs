using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNeg
{
    public class Estudiante : Persona
    {

        public Estudiante(string nombre  ):base(nombre )
        {
            
        }

        public void estudiar()
        {
            Console.WriteLine($"{Nombre}Estudio programacion ");
        }
    }
}
