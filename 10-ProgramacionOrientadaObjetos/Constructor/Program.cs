using Constructor.Models;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", "Perez");
            Persona persona2 = new Persona("Maria", "Gomez");
            persona2.Nombre = "";

        }
    }
}