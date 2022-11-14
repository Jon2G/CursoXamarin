using ApisNativas.iOS.Servicios;
using ApisNativas.Servicios;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DialogService))]
namespace ApisNativas.iOS.Servicios
{
    public class DialogService : IDialogService
    {
        public void ShowMessage(string message)
        {
            //https://www.appsdeveloperblog.com/how-to-show-an-alert-in-swift/
            var dialogMessage = UIAlertController.Create("Hola desde iOS", message, UIAlertControllerStyle.Alert);
            dialogMessage.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (a) =>
            {
                //ToastOk button click task
                var toast = UIAlertController.Create("Ok", "iOS", UIAlertControllerStyle.ActionSheet);
                toast.ShowViewController(dialogMessage, null);

                UIApplication.SharedApplication.InputViewController.PresentViewController(toast, true, null);

            }));
            UIApplication.SharedApplication.InputViewController.PresentViewController(dialogMessage, true, null);
        }
    }
}