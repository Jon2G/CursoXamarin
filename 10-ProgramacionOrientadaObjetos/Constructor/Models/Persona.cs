namespace Constructor.Models
{
    internal class Persona
    {
        private string Nombre;
        private string Apellidos;

        public Persona(string nombre, string apellidos)
        {
            Nombre = nombre;
            Apellidos = apellidos;
        }
    }
}
