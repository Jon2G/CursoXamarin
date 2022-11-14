using System;
using Xamarin.Forms;

namespace DemoAcr
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Acr.UserDialogs.UserDialogs.Instance.Alert(TxtName.Text, "Hola desde ACR", "Ok");
            Acr.UserDialogs.UserDialogs.Instance.Toast("Ok ACR");
        }
    }
}
