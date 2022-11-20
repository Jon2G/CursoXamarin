using Demo.Models;

Carro Carro = new Carro()
{
    Color = "Rojo",
    Marca = "Toyota",
    Modelo = "Corolla",
    Placa = "ABC-123",
    Velocidad = 0,
    Detenido = true,
};

Carro.Acelerar();
Carro.Acelerar();

Carro.Frenar();
Carro.Frenar();
