using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greece.ViewModel
{
 
    public partial class MainPageViewModel : BaseViewModel
    {
        [RelayCommand] // Vet ej om den ska va kvar
        async Task GoTO()
        {
            await Shell.Current.GoToAsync($"{nameof(IslandsPage)}");
        }
       
    }
}
