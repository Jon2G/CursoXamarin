namespace ManejoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numero1 = 9;
                int numero2 = 0;
                int resultado = numero1 / numero2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No es posible dividir un número entre cero: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("El programa ha finalizado");
            }
        }
    }
}