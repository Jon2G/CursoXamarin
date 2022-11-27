using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaAsistencia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlumnosView : ContentPage
    {
        public AlumnosView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Model.Refresh();
        }
    }
}