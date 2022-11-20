namespace Demo.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Placa { get; set; }
        public float Velocidad { get; set; }
        public bool Detenido { get; set; }
        public void Acelerar()
        {
            Velocidad += 10;
            if (Detenido)
            {
                Detenido = false;
                Console.WriteLine("El carro arrancó");
            }

            Console.WriteLine("Acelerando..., velocidad actual: " + Velocidad);
        }
        public void Frenar()
        {
            Velocidad -= 10;
            Console.WriteLine("Frenando..., velocidad actual: " + Velocidad);
            if (Velocidad <= 0)
            {
                Velocidad = 0;
                Detenido = true;
                Console.WriteLine("El carro se detuvo");
            }

        }
    }
}
