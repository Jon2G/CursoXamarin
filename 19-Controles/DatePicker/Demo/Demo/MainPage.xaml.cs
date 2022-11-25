using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public DateTime Date { get; set; }
        public MainPage()
        {
            Date = DateTime.Now;
            this.BindingContext = this;
            InitializeComponent();
        }
    }
}
