using LiteDB;
using System.ComponentModel;
using Xamarin.Forms;

namespace ListaAsistencia.Models
{
    public class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [LiteDB.BsonId(true)]
        public int Id { get; set; }
        public string Boleta { get; set; }

        public string Nombre { get; set; }

        public string Photo { get; set; }

        [BsonIgnore]
        public ImageSource PhotoSource { get; set; }

        public Alumno()
        {

        }
    }
}
