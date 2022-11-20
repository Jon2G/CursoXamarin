using Listview.Models;
using System.Collections.ObjectModel;

namespace Listview.ViewModels
{
    internal class MainPageViewModel
    {
        public ObservableCollection<Employes> Employees { get; set; }
        public MainPageViewModel()
        {
            Employees = new ObservableCollection<Employes>{
                new Employes("Juan","Perez","Developer","Juan@hotmail.com" ),
                new Employes("Maria","Gomez","Developer","Maria@hotmail.com" ),
                new Employes("Pedro","Gonzalez","Developer","Pedro@hotmail.com" ),
                new Employes("Luis","Martinez","Developer","Luis@hotmail.com" ),
                new Employes("Ana","Rodriguez","Developer","Ana@hotmail.com" )

                };
        }
    }
}
