int[,] calificaciones = new int[2, 3];

for (int alumno = 0; alumno < 2; alumno++)
{
    for (int parcial = 0; parcial < 3; parcial++)
    {
        Console.WriteLine("Ingrese la calificación del alumno {0} en el parcial {1}", alumno + 1, parcial + 1);
        calificaciones[alumno, parcial] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Calificaciones de los alumnos");
for (int alumno = 0; alumno < 2; alumno++)
{
    for (int parcial = 0; parcial < 3; parcial++)
    {
        Console.Write(calificaciones[alumno, parcial] + " ");
    }
    Console.WriteLine();
}