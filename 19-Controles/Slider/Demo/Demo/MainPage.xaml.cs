using System.ComponentModel;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public double Valor { get; set; }
        public MainPage()
        {
            this.Valor = 0;
            this.BindingContext = this;
            InitializeComponent();
        }
    }
}
