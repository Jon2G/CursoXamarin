using ApisNativas.Servicios;
using System;
using Xamarin.Forms;

namespace ApisNativas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IDialogService>().ShowMessage(TxtName.Text);
        }
    }
}
