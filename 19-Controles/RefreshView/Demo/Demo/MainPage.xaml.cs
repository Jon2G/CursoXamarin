using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public Command RefreshCommand { get; set; }
        public bool IsRefreshing { get; set; }
        public MainPage()
        {
            RefreshCommand = new Command(Refresh);
            this.BindingContext = this;
            InitializeComponent();
        }

        private async void Refresh()
        {
            // Do your refresh logic here
            await Task.Delay(2000).ContinueWith((t) =>
            {
                Device.InvokeOnMainThreadAsync(async () =>
                {
                    IsRefreshing = false;
                    await DisplayAlert("End", "Refresh end", "Ok");
                });

            });
        }
    }
}
