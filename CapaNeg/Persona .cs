namespace CapaNeg
{
    public class Persona 

    {
       

        public string Nombre;



        public Persona(string nombre )
        {
            this.Nombre = nombre;
          
        }






        public override string ToString()
        {
            return $"El nombre es {Nombre}";
        }
    }
}
