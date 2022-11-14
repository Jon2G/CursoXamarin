using System.Threading.Tasks;
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
            var topVC = UIApplication.SharedApplication.KeyWindow.RootViewController;
            while (topVC.PresentedViewController != null)
            {
                topVC = topVC.PresentedViewController;
            }

            //https://www.appsdeveloperblog.com/how-to-show-an-alert-in-swift/
            var dialogMessage = UIAlertController.Create("Hola desde iOS", message, UIAlertControllerStyle.Alert);
            dialogMessage.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, (a) =>
            {
                var toast = UIAlertController.Create("Ok", "iOS", UIAlertControllerStyle.ActionSheet);
                toast.ShowViewController(dialogMessage, null);

                topVC.PresentViewController(toast, true, () =>
                {
                    UITapGestureRecognizer recognizer = new UITapGestureRecognizer((tapRecognizer) =>
                    {
                        toast.DismissViewController(true, null);
                    });
                    // After testing, The first subview of the screen can be used for adding gesture to dismiss the action sheet
                    toast.View.Superview.Subviews[0].AddGestureRecognizer(recognizer);
                });

            }));
            topVC.PresentViewController(dialogMessage, true, null);
        }
    }
}