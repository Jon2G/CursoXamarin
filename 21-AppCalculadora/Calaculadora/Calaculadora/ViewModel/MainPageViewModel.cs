using AngouriMath;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculadora.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Operacion { get; set; }

        public string Resultado { get; set; }

        public ICommand DeleteCommand { get; set; }
        public ICommand CalcularCommand { get; set; }
        public MainPageViewModel()
        {
            DeleteCommand = new Command(Delete);
            CalcularCommand = new Command<string>(Calcular);
        }
        private void Delete()
        {
            Operacion = string.Empty;
            Resultado = string.Empty;
        }
        private void Calcular(string content)
        {
            if (content == "=")
            {
                Resultado = Calcular().ToString("N2");
                Operacion = Resultado;
                return;
            }
            else if (content == "!")
            {
                Operacion += "*-1";
                Calcular("=");
                return;
            }
            Operacion += content;

        }

        private float Calcular()
        {
            try
            {
                Entity expr = Operacion;
                float resultado = (float)expr.EvalNumerical();
                return resultado;
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Operación no valida.", "Alerta", "Ok");
                Delete();
            }
            return 0;
        }
    }
}
