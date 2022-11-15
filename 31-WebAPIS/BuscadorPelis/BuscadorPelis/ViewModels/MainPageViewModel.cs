using BuscadorPelis.Models;
using BuscadorPelis.Services;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BuscadorPelis.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsLoading { get; set; }
        public string TitleSearch { get; set; }
        public Movie Movie { get; set; }
        public ICommand SearchCommand { get; set; }
        private readonly Omdb Omdb;

        public MainPageViewModel()
        {
            SearchCommand = new Command(Search);
            Omdb = new Omdb();
        }

        private async void Search()
        {
            IsLoading = true;
            Movie = null;
            if (string.IsNullOrEmpty(this.TitleSearch))
            {
                return;
            }
            this.Movie = await this.Omdb.Search(this.TitleSearch);
            IsLoading = false;
        }
    }
}
