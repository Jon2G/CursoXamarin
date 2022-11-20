namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>(); //Declaración de una lista

            int[] arregloNumeros = new int[] { 3, 6, 8, 10, 50 };

            for (int i = 0; i < 5; i++)
            {
                listaNumeros.Add(arregloNumeros[i]); //Agrega los elementos del arreglo a la lista
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }

        }

    }
}