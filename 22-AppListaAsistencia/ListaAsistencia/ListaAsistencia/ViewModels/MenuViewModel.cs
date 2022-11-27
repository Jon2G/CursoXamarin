using ListaAsistencia.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaAsistencia.ViewModels
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand TomarAsistenciaCommand { get; set; }
        public ICommand VerAsistenciasCommand { get; set; }

        public MenuViewModel()
        {
            TomarAsistenciaCommand = new Command(TomarAsistencia);
        }

        private void TomarAsistencia()
        {
            Shell.Current.FlyoutIsPresented = false;
            Shell.Current.Navigation.PushAsync(new TomarAsistenciaView(), true);
        }



    }
}
