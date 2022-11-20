using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public ICommand Command { get; set; }
        public MainPage()
        {
            Command = new Command(Click);
            this.BindingContext = this;
            InitializeComponent();
        }

        private void Click()
        {
            DisplayAlert("Click", "Comando click", "Ok");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Click", "Evento click", "Ok");
        }
    }
}
