using System.Windows.Input;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public ICommand BuscarCommand { get; set; }
        public MainPage()
        {
            BuscarCommand = new Command(Buscar);
            this.BindingContext = this;
            InitializeComponent();
        }

        private void Buscar()
        {
            DisplayAlert("Alert", "Buscar", "OK");
        }
    }
}
