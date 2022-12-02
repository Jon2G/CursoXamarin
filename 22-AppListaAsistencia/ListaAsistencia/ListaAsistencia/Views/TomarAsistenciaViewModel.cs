using ListaAsistencia.Data;
using ListaAsistencia.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaAsistencia.ViewModels
{
    public class TomarAsistenciaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime Fecha { get; set; }
        public ObservableCollection<Asistencia> Asistencias { get; set; }
        public ICommand ConfirmarCommand { get; set; }
        public TomarAsistenciaViewModel()
        {
            Fecha = DateTime.Today;
            Asistencias = new ObservableCollection<Asistencia>();
            ConfirmarCommand = new Command(Confirmar);
            Refresh();
        }

        private void Confirmar()
        {
            foreach (var asistencia in Asistencias)
            {
                asistencia.Id = (asistencia.IdAlumno + "-" + Fecha.ToString("dd_MM_yyyy"));
                asistencia.Fecha = Fecha;
                AppData.Save(asistencia);
            }
            Shell.Current.Navigation.PopAsync(true);
        }
        public void Refresh()
        {
            Asistencias.Clear();
            var alumnos = AppData.GetAll<Alumno>();
            foreach (var alumno in alumnos)
            {
                if (alumno.Photo != null)
                {
                    var photo = Convert.FromBase64String(alumno.Photo);
                    alumno.PhotoSource = ImageSource.FromStream(() => new MemoryStream(photo));
                }

                Asistencia asistencia =
                AppData.Database.GetCollection<Asistencia>()
                    .Query()
                    .Where(x => x.IdAlumno == alumno.Id)
                    .Where(x => x.Fecha == Fecha).FirstOrDefault();

                if (asistencia == null)
                {
                    asistencia = new Asistencia()
                    {
                        IdAlumno = alumno.Id,
                        Asistio = false
                    };
                }

                asistencia.Alumno = alumno;

                Asistencias.Add(asistencia);
            }
        }
    }
}
