using Calaculadora.ViewModel;
using Xamarin.Forms;

namespace Calaculadora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
