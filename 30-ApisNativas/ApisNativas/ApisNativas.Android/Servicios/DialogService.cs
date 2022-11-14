using Android.App;
using Android.Widget;
using ApisNativas.Droid.Servicios;
using ApisNativas.Servicios;
using Xamarin.Forms;

[assembly: Dependency(typeof(DialogService))]
namespace ApisNativas.Droid.Servicios
{
    public class DialogService : IDialogService
    {
        public void ShowMessage(string message)
        {
            var activity = MainActivity.Context;
            //https://developer.android.com/develop/ui/views/components/dialogs
            AlertDialog.Builder builder = new AlertDialog.Builder(activity);
            AlertDialog alert = builder.Create();
            alert.SetTitle("Hola desde Android");
            alert.SetMessage(message);
            alert.SetButton("OK", (c, ev) =>
            {
                // Ok button click task  
                Toast.MakeText(activity, "Ok,Android", ToastLength.Long)?.Show();
            });
            alert.Show();
        }
    }
}