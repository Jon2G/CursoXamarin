using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public double Progreso { get; set; }
        public MainPage()
        {
            this.Progreso = 0;
            this.BindingContext = this;
            InitializeComponent();
            DoProgress();
        }

        private void DoProgress()
        {
            Device.BeginInvokeOnMainThread(() =>
            Task.Delay(500).ContinueWith(t =>
            {
                if (Progreso >= 1.0)
                {
                    Progreso = 0.0;
                }
                Progreso += 0.1;
                DoProgress();
            }));
        }
    }
}
