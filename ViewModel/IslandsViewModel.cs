using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greece.Services;
using Greece.View;

namespace Greece.ViewModel
{
    public partial class IslandsViewModel : BaseViewModel
    {
        IslandService islandService;
        public ObservableCollection<Island> Islands { get; } = new();

        IConnectivity connectivity;
        IGeolocation geolocation;

        public IslandsViewModel(IslandService islandService, IConnectivity connectivity, IGeolocation geolocation)
        {
            Title = "Greek Islands";
            this.islandService = islandService;
            this.connectivity = connectivity;
            this.geolocation = geolocation;
        }

        [RelayCommand]
        async Task GetClosestIslandAsync()
        {
            if (IsBusy || Islands.Count == 0)
                return;

            try
            {

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to get closest island: {ex.Message}", "OK");
            }
        }
        [RelayCommand]
        async Task GoToDetailsAsync(Island island)
        {
            if (island is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true,
                new Dictionary<string, object>
                {
                    {"Island", island }
                });
        }

        [RelayCommand]
        async Task GetIslandsAsync()
        {
            if (IsBusy) return;

            try
            {
                if(connectivity.NetworkAccess != NetworkAccess.Internet)
                {

                    await Shell.Current.DisplayAlert("Internet issue!",
                        $"Check your internet connection and try again!", "OK");
                    return;
                }

                IsBusy= true;
                var islands = await islandService.GetIslands();

                if (Islands.Count != 0)
                    Islands.Clear();

                foreach(var island in islands)
                    Islands.Add(island);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to get islands: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
