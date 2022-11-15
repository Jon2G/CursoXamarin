using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BibliotecaFotos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                Img.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
