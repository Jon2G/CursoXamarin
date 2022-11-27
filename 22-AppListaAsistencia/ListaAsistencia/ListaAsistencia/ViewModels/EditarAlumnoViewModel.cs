using AsyncAwaitBestPractices.MVVM;
using ListaAsistencia.Data;
using ListaAsistencia.Models;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ListaAsistencia.ViewModels
{
    public class EditarAlumnoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Boleta { get; set; }
        public string Nombre { get; set; }
        public ImageSource Photo { get; set; }
        public string Base64Photo { get; set; }

        public ICommand SaveCommand { get; set; }
        public ICommand TomarFotoCommand { get; set; }
        public ICommand SeleccionarFotoCommand { get; set; }


        public EditarAlumnoViewModel(Alumno alumno)
        {
            this.Id = alumno.Id;
            this.Boleta = alumno.Boleta;
            this.Nombre = alumno.Nombre;
            this.Photo = alumno.Photo;
            if (alumno.Photo != null)
            {
                var photo = Convert.FromBase64String(alumno.Photo);
                Photo = ImageSource.FromStream(() => new MemoryStream(photo));
            }
            Init();
        }

        public EditarAlumnoViewModel()
        {
            Init();
        }

        private void Init()
        {
            SaveCommand = new Command(Save);
            TomarFotoCommand = new AsyncCommand(TomarFoto);
            SeleccionarFotoCommand = new AsyncCommand(SeleccionarFoto);
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(Boleta))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("El campo boleta es requerido", "Alerta", "Ok");
                return;
            }

            Regex regexBoleta = new Regex("([0-9]{10})");
            if (!regexBoleta.IsMatch(Boleta))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("El formato de la boleta no es válido", "Alerta", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(Nombre))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("El nombre es requerido", "Alerta", "Ok");
                return;
            }

            AppData.Save(new Alumno
            {
                Id = Id,
                Nombre = Nombre,
                Boleta = Boleta,
                Photo = Base64Photo
            });
            Shell.Current.Navigation.PopAsync(true);
        }

        private async Task SeleccionarFoto()
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                await LoadPhotoAsync(photo);
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert(ex.Message, "Error", "Ok");
            }
        }

        private async Task TomarFoto()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
            }
            catch (FeatureNotSupportedException)
            {
                // Feature is not supported on the device
                Acr.UserDialogs.UserDialogs.Instance.Alert("Tu dispositivo no soporta esta función", "Error", "Ok");
            }
            catch (PermissionException ex)
            {
                // Permissions not granted
                Acr.UserDialogs.UserDialogs.Instance.Alert("Por favor conceda el acceso a la camará desde ajustes", "Error", "Ok");
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert(ex.Message, "Error", "Ok");
            }
        }

        async Task TakePhotoAsync()
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                await LoadPhotoAsync(photo);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature is not supported on the device
            }
            catch (PermissionException pEx)
            {
                // Permissions not granted
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CapturePhotoAsync THREW: {ex.Message}");
            }
        }

        private async Task LoadPhotoAsync(FileResult photo)
        {
            // canceled
            if (photo == null)
            {
                Photo = null;
                return;
            }

            MemoryStream memoryStream = new MemoryStream();
            using (Stream stream = await photo.OpenReadAsync())
            {
                stream.Position = 0;
                await stream.CopyToAsync(memoryStream);
            }
            Base64Photo = Convert.ToBase64String(memoryStream.ToArray());
            memoryStream.Position = 0;
            Photo = ImageSource.FromStream(() => memoryStream);
        }
    }
}
