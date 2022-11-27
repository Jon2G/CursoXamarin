using AsyncAwaitBestPractices.MVVM;
using ListaAsistencia.Data;
using ListaAsistencia.Models;
using ListaAsistencia.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaAsistencia.ViewModels
{
    public class AlumnosViewModels : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Alumno> Alumnos { get; set; }
        public ICommand NuevoAlumnoCommand { get; set; }
        public ICommand EditarAlumnoCommand { get; set; }
        public ICommand EliminarAlumnoCommand { get; set; }
        public AlumnosViewModels()
        {
            Alumnos = new ObservableCollection<Alumno>();
            NuevoAlumnoCommand = new Command(NuevoAlumno);
            EditarAlumnoCommand = new Command<Alumno>(EditarAlumno);
            EliminarAlumnoCommand = new AsyncCommand<Alumno>(EliminarAlumno);
        }

        private void NuevoAlumno()
        {
            Shell.Current.Navigation.PushAsync(new EditarAlumnoView(), true);
        }

        private void EditarAlumno(Alumno alumno)
        {
            Shell.Current.Navigation.PushAsync(new EditarAlumnoView(alumno), true);
        }

        private async Task EliminarAlumno(Alumno alumno)
        {
            if (await Acr.UserDialogs.UserDialogs.Instance.ConfirmAsync("¿Estás seguro de eliminar este alumno?"))
            {
                AppData.Delete<Alumno>(alumno.Id);
                Refresh();
            }
        }

        public void Refresh()
        {
            Alumnos.Clear();

            Alumno[] alumnos = AppData.GetAll<Alumno>();
            foreach (Alumno alumno in alumnos)
            {
                if (alumno.Photo != null)
                {
                    var photo = Convert.FromBase64String(alumno.Photo);
                    alumno.PhotoSource = ImageSource.FromStream(() => new MemoryStream(photo));
                }
                Alumnos.Add(alumno);
            }
        }
    }
}
