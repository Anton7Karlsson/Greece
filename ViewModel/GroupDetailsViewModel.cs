using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greece.ViewModel
{
    [QueryProperty(nameof(Islandgroup), "IslandGroup")]
    public partial class GroupDetailsViewModel : BaseViewModel
    {
        public GroupDetailsViewModel()
        {
            
        }
        [ObservableProperty]
        IslandGroup islandgroup;


        

        // Go back one page
        //[RelayCommand]
        //async Task GoBackAsync()
        //{
        //    await Shell.Current.GoToAsync("..");
        //}
    }
}