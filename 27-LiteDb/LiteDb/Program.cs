using LiteDB;
using Sample.Models;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            using (var db = new LiteDatabase("MyData.db"))
            {

                // Obtiene una coleción (o crea una nueva, si no existe)
                var col = db.GetCollection<Alumno>("customers");

                // Crea un nuevo alumno
                var alumno = new Alumno
                {
                    Nombre = "John Doe",
                    Edad = 39,
                };

                // Insert un nuevo documento de alumno (El id sera autoincrementado) 
                col.Insert(alumno);

                // Actualiza el nombre del aclumno
                alumno.Nombre = "Jane Doe";

                //Salva el documento actualizado
                col.Update(alumno);

                //Elimina un alumno por su id
                col.Delete(alumno.Id);

                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query()
                    .Where(x => x.Nombre.StartsWith("J"))
                    .OrderBy(x => x.Nombre)
                    .Select(x => new { x.Nombre, NameUpper = x.Nombre.ToUpper() })
                    .Limit(10)
                    .ToList();
            }
        }
    }

}
