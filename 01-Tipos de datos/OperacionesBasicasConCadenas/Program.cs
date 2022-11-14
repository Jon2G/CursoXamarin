Console.WriteLine("Ingresa tu nombre:");
string mensaje = "Bienvenido a C#:";
string nombre = Console.ReadLine();
string saludo = mensaje + nombre; //Concatenación
Console.WriteLine(mensaje + nombre);

string caracterEspecial = "Escapar comillas dobles \"C#\" es sencillo"; //Caracteres especiales
Console.WriteLine(caracterEspecial);

DateTime fecha = DateTime.Now;

string hoyEs = "Hoy es: " + fecha.ToString("D"); //Conversión de tipos de datos a cadena
Console.WriteLine(hoyEs);

string cadenaFormato = string.Format("Hola,{0} hoy es:{1}", nombre, fecha); //Formato de cadenas
Console.WriteLine(cadenaFormato);

string interpolacion = $"Hola,{nombre} hoy es:{fecha}"; //Interpolación de cadenas
Console.WriteLine(interpolacion);