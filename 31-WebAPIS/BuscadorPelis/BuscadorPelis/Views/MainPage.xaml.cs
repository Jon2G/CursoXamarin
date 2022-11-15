using BuscadorPelis.ViewModels;
using Xamarin.Forms;

namespace BuscadorPelis
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel Model;
        public MainPage()
        {
            this.Model = new MainPageViewModel();
            InitializeComponent();
            this.BindingContext = this.Model;
        }
    }
}
