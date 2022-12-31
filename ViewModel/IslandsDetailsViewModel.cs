using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greece.ViewModel
{
    [QueryProperty("Island", "Island")]
    public partial class IslandsDetailsViewModel : BaseViewModel
    {
        public IslandsDetailsViewModel()
        {
        }

        [ObservableProperty]
        Island island;

        // Go back one page
        //[RelayCommand]
        //async Task GoBackAsync()
        //{
        //    await Shell.Current.GoToAsync("..");
        //}
    }
}
