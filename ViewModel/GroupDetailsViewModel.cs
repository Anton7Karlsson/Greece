using Greece.View;
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
        public ObservableCollection<IslandGroup> IslandGroups { get; } = new();
        public ObservableCollection<Island> Islands { get; set; } = new();
        public GroupDetailsViewModel()
        {
            
        }
        [ObservableProperty]
        IslandGroup islandgroup;


        [RelayCommand]
        async Task GoToIslandDetailsAsync(Island island)
        {
            if (island is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                new Dictionary<string, object>
                {
                    {"Island", island }
                });
        }

        // Go back one page
        //[RelayCommand]
        //async Task GoBackAsync()
        //{
        //    await Shell.Current.GoToAsync("..");
        //}
    }
}