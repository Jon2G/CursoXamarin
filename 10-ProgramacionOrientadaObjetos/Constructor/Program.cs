using Constructor.Models;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", "Perez");
            Persona persona2 = new Persona("Maria", "Gomez");

            Persona persona3 = new Persona("", "");

            Console.WriteLine(persona1.Nombre);
            persona1.Nombre = "Mar";


            persona2.ImprimirNombre();
        }
    }
}