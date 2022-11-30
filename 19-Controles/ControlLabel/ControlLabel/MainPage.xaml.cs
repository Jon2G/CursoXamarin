using Xamarin.Forms;

namespace ControlLabel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Cargar el contenido del xaml para representarlo en la vista
            InitializeComponent();
        }
        //Evento clicked del botón 
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            string valor = this.LblDinamico.Text;
            if (valor == "Texto dinámico")
            {
                this.LblDinamico.Text = "Este texto fue modificado";
            }
            else
            {
                this.LblDinamico.Text = "Texto dinámico";
            }
        }
    }
}
