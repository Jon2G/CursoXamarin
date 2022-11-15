using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using Xamarin.Forms;

namespace Biometricos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var request = new AuthenticationRequestConfiguration("Prove you have fingers!", "Because without it you can't have access");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);
            if (result.Authenticated)
            {
                // do secret stuff :)
                await DisplayAlert("Success", "You are allowed to enter", "OK");
            }
            else
            {
                // not allowed to do secret stuff :(
                await DisplayAlert("Failure", "You are not allowed to enter", "OK");
            }
        }
    }
}
