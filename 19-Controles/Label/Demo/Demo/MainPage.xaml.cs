using NameGenerator.Generators;
using System;
using System.ComponentModel;
using System.Threading;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public string Texto { get; set; }
        private RealNameGenerator _generator;
        public MainPage()
        {
            Texto = "Este texto es dinámico";
            InitializeComponent();
            _ = new Timer((t) => CambiarTexto(), null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(5));
            _generator = new RealNameGenerator();
            this.BindingContext = this;
        }

        private void CambiarTexto()
        {
            Texto = _generator.Generate();
        }
    }
}
