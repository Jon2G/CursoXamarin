namespace Diccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            //llenamos el diccionario
            edades.Add("Juan", 20);
            edades.Add("Daniel", 29);

            edades["Lalo"] = 31;
            edades["Antonio"] = 16;

            //Recorrer el diccionario

            foreach (KeyValuePair<string, int> item in edades)
            {
                Console.WriteLine("Nombre: {0} Edad: {1} ", item.Key, item.Value);
            }
        }

    }
}