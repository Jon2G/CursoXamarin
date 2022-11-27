using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaAsistencia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TomarAsistenciaView : ContentPage
    {
        public TomarAsistenciaView()
        {
            InitializeComponent();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            this.Model.Refresh();
        }
    }
}