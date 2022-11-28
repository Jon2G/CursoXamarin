using Demo.Models;

Carro auto = new Carro()
{
    Color = "Rojo",
    Marca = "Toyota",
    Modelo = "Corolla",
    Placa = "ABC-123",
    Velocidad = 0,
    Detenido = true,
};

auto.Acelerar();
auto.Acelerar();

while (auto.Detenido == false)
{
    auto.Frenar();
}

