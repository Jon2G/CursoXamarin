using LiteDB;
using System;

namespace ListaAsistencia.Models
{
    public class Asistencia
    {
        [BsonId(false)]
        public string Id { get; set; }
        public int IdAlumno { get; set; }
        public DateTime Fecha { get; set; }
        public bool Asistio { get; set; }
        [BsonIgnore]
        public Alumno Alumno { get; set; }

        public Asistencia()
        {
        }
    }
}
