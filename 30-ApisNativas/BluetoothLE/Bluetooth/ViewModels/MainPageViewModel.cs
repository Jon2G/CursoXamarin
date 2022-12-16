using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.EventArgs;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Bluetooth.ViewModels
{
    internal class MainPageViewModel
    {
        IBluetoothLE BluetoothLE;
        IAdapter Adapter;
        public Command ScanDevicesCommand { get; set; }
        public ObservableCollection<IDevice> Dispositivos { get; set; }

        public MainPageViewModel()
        {
            this.BluetoothLE = CrossBluetoothLE.Current;
            this.Adapter = CrossBluetoothLE.Current.Adapter;
            this.Adapter.DeviceDiscovered += DispositivoEncontrado;
            this.ScanDevicesCommand = new Command(ScanDevices);
            this.Dispositivos = new ObservableCollection<IDevice>();
        }

        bool VerificarBluetooth()
        {
            switch (this.BluetoothLE.State)
            {
                case BluetoothState.On:
                    return true;

                case BluetoothState.TurningOff:
                case BluetoothState.Off:
                    //mensaje;
                    App.Current.MainPage.DisplayAlert("Bluetooth", "El Bluetooth está apagado", "OK");
                    return false;

                case BluetoothState.Unauthorized:
                    //mensaje
                    App.Current.MainPage.DisplayAlert("Bluetooth",
                        "Conceda el acceso al bluetooth desde ajustes de la app.", "OK");
                    return false;

                case BluetoothState.Unavailable:
                    //mensaje
                    App.Current.MainPage.DisplayAlert("Bluetooth",
                        "El Bluetooth no está disponible en este dispositivo.", "OK");
                    return false;

                default:
                case BluetoothState.Unknown:
                    //mensaje
                    App.Current.MainPage.DisplayAlert("Bluetooth",
                        "El estado del Bluetooth es desconocido.", "OK");
                    return false;
            }
        }

        void ScanDevices()
        {
            if (VerificarBluetooth())
            {
                //Buscar dispositivos cercanos
                Dispositivos.Clear();
                this.Adapter.ScanMode = ScanMode.Balanced;
                this.Adapter.ScanTimeout = 300000;
                this.Adapter.StartScanningForDevicesAsync(allowDuplicatesKey: true);
            }
        }

        void DispositivoEncontrado(object o, DeviceEventArgs e)
        {
            IDevice dispositivo = e.Device;
            //if (dispositivo != null && dispositivo.Name != null)
            //{
            Dispositivos.Add(dispositivo);
            //}
        }
    }
}
