//Declaramos una matriz bidimensional.
//Para ello colocamos una coma entre los corchetes.
int[,] mEjemplo;
//Construimos la matriz y le damos una dimensión
mEjemplo = new int[3, 4];
//Esto indica 3 filas y 4 columnas

//Creamos un objeto de la clase Random para generar números aleatorios
Random random = new Random();


//Bucle para recorrer las filas
for (int fila = 0; fila < 3; fila++)
{
    //Cuando entramos por primera vez en este bucle
    //estamos en la columna cero.
    //Bucle para recorrer las columnas
    for (int columna = 0; columna < 4; columna++)
    {
        //Colocamos en valor en la fila y columna correspondientes
        mEjemplo[fila, columna] = random.Next(10, 99); //obtiene un número aleatorio entre 10 y 99

        //Imprime el nuevo valor de la celda
        Console.Write(mEjemplo[fila, columna] + "\t");
    }
    Console.WriteLine();
}