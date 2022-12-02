using AngouriMath;
using System;
using System.ComponentModel; //importa INotifyPropertyChanged
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculadora.ViewModel
{
    internal class MainPageViewModel : INotifyPropertyChanged
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
            Operacion = "";
            Resultado = "";
        }
        private void Calcular(string content)
        {
            if (content == "=")
            {
                Resultado = CalcularAngouri().ToString("N2");
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

        private float CalcularAngouri()
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
