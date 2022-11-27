using ListaAsistencia.Models;
using ListaAsistencia.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaAsistencia.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarAlumnoView : ContentPage
    {
        public EditarAlumnoView()
        {
            this.BindingContext = new EditarAlumnoViewModel();
            InitializeComponent();
        }

        public EditarAlumnoView(Alumno alumno)
        {
            this.BindingContext = new EditarAlumnoViewModel(alumno);
            InitializeComponent();
        }
    }
}