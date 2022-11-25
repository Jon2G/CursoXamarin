using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public TimeSpan Time { get; set; }
        public MainPage()
        {
            Time = DateTime.Now.TimeOfDay;
            this.BindingContext = this;
            InitializeComponent();
        }
    }
}
