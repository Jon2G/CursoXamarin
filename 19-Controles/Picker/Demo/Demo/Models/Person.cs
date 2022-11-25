using System.ComponentModel;

namespace Demo.Models
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}
