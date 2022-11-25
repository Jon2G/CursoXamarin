using Bogus;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Demo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Models.Person> People { get; set; }
        public Models.Person SelectedPerson { get; set; }
        public int SelectedIndex { get; set; }
        public MainPageViewModel()
        {
            People = new ObservableCollection<Models.Person>();
            GenerateData();
        }


        private void GenerateData()
        {
            var testUsers = new Faker<Models.Person>()
                .RuleFor(u => u.Photo, f => f.Internet.Avatar())
                .RuleFor(u => u.Name, f => f.Person.FullName);

            for (int i = 0; i < 10; i++)
            {
                Models.Person person = testUsers.Generate();
                People.Add(person);
            }
        }


    }
}
