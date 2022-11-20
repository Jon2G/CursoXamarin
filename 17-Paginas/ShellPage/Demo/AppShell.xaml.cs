using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await AppShell.Current.Navigation.PopToRootAsync();
            await AppShell.Current.Navigation.PushAsync(new HelloPage());
            Shell.Current.FlyoutIsPresented = false;
        }

        private async void Button_Clicked_1(object sender, System.EventArgs e)
        {
            await this.Navigation.PopToRootAsync();
            await AppShell.Current.Navigation.PushAsync(new AboutPage());
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}