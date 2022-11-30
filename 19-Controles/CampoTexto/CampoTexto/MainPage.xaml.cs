using CampoTexto.Fonts;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace CampoTexto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            bool mostrado = this.TxtPassword.IsPassword;

            //mostrado = !mostrado;
            if (mostrado == true)
            {
                mostrado = false;
            }
            else
            {
                mostrado = true;
            }
            this.TxtPassword.IsPassword = mostrado;
        }
        private async void MostrarOcultarPassword(object sender, EventArgs e)
        {
            this.TxtPassword.IsPassword = false;
            this.BtnVer.Text = FontAwesome.EyeSlash; //Cambiar icono del botón
            await Task.Delay(1000).
                ContinueWith(OcultarPassword);
        }
        private void OcultarPassword(Task task)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                this.TxtPassword.IsPassword = true;
                this.BtnVer.Text = FontAwesome.Eye; //Cambiar icono del botón
            }
                );
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string usuario = this.TxtUsuario.Text;
            string password = this.TxtPassword.Text;
            if (usuario == "admin" && password == "1234")
            {
                //correcto
                this.DisplayAlert("Correcto", "Bienvenido", "Ok");
            }
            else
            {
                //limpiar campos de texto 
                this.TxtUsuario.Text = "";
                this.TxtPassword.Text = "";
                this.DisplayAlert("Mensaje de error", "Usuario contraseña incorrectos", "Aceptar");
            }
        }
    }
}