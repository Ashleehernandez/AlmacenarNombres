using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNeg
{
    public class Profesor : Persona
    {

        public Profesor(string nombre  ):base(nombre )
        {
            
        }

        public void IMPARTIR ( )
        {
            Console.WriteLine($"{Nombre}Imparto clase de programacion");
        }
    }
}
