using Android.OS;
using AndroidX.Core.App;
using Bluetooth.Interfaces;
using Xamarin.Forms;
[assembly: Dependency(typeof(Bluetooth.Droid.Interfaces.PermisoBluetooth))]

namespace Bluetooth.Droid.Interfaces
{
    internal class PermisoBluetooth : IPermisoBluetooth
    {
        public void SolicitarPermiso()
        {
            string[] permisos;
            if ((int)Build.VERSION.SdkInt <= 30)
            {
                permisos = new[]
                {
                    "android.permission.BLUETOOTH",
                    "android.permission.BLUETOOTH_ADMIN",
                    "android.permission.ACCESS_COARSE_LOCATION",
                    "android.permission.ACCESS_FINE_LOCATION"
                };
            }
            else
            {
                permisos = new[]
                {
                    "android.permission.BLUETOOTH_ADVERTISE",
                    "android.permission.BLUETOOTH_CONNECT",
                    "android.permission.BLUETOOTH_SCAN",
                    "android.permission.ACCESS_COARSE_LOCATION",
                    "android.permission.ACCESS_FINE_LOCATION"
                };
            }
            ActivityCompat.RequestPermissions(MainActivity.Instancia, permisos, 0);
        }
    }
}