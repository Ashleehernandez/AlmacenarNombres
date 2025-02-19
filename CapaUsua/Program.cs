using CapaNeg;
namespace CapaUsua
{
    public class Program

    {
        static Persona[] personas = new Persona[3];

        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el nombre del primer estudiante ");
            personas[0] = new Estudiante(Console.ReadLine()!);


            Console.WriteLine("ingrese el nombre del otro estudiante ");
            personas[1] = new Estudiante(Console.ReadLine()!);

            Console.WriteLine("ingrese el nombre del maestro ");
            personas[2] = new Profesor(Console.ReadLine()!);




            foreach
                    (Persona persona in personas)
            {
                if (persona is Estudiante estudiante)
                {
                    estudiante.estudiar();
                }
                else if (persona is Profesor profesor)
                {
                    {
                        profesor.IMPARTIR(); ;


                    }
                }


            }
        }
    }
}
