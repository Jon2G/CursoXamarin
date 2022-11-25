using System.Windows.Input;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public ICommand AddCommand { get; set; }
        public MainPage()
        {
            AddCommand = new Command(Add);
            this.BindingContext = this;
            InitializeComponent();
        }

        public void Add()
        {
            DisplayAlert("Swipe activado", "Agregar", "Ok");
        }
    }
}
