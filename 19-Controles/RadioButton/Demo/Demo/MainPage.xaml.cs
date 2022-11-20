using System;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public string Opcion2 { get; set; }
        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Opción seleccionada", "Seleccionaste la opción:" + Opcion2, "Ok");
        }
    }
}
