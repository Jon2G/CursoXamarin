using System.ComponentModel;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public bool Estado { get; set; }
        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();
        }
    }
}
