using DemoFlyout.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemoFlyout.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}