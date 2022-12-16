using Bluetooth.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bluetooth
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IPermisoBluetooth permiso = DependencyService.Get<IPermisoBluetooth>();
            permiso.SolicitarPermiso();
        }
    }
}
