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
        IMap map;
        public IslandsDetailsViewModel(IMap map)
        {
            this.map = map;
        }

        [ObservableProperty]
        Island island;

        [RelayCommand]
        async Task OpenMapAsync()
        {
            try
            {
                await map.OpenAsync(Island.Latitude, Island.Longitude,
                    new MapLaunchOptions
                    {
                        Name = Island.Name,
                        NavigationMode = NavigationMode.None
                    });
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to open map: {ex.Message}", "OK");
            }
        }

        // Go back one page
        //[RelayCommand]
        //async Task GoBackAsync()
        //{
        //    await Shell.Current.GoToAsync("..");
        //}
    }
}
