using Greece.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greece.View;

namespace Greece.ViewModel
{
    public partial class IslandGroupsViewModel : BaseViewModel
    {
        IslandGroupService islandGroupService;

        public ObservableCollection<IslandGroup> IslandGroups { get; } = new();

        IConnectivity connectivity;

        public IslandGroupsViewModel(IslandGroupService islandGroupService, IConnectivity connectivity)
        {
            Title = "Greek Islandgroups";
            this.islandGroupService = islandGroupService;
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        bool isRefreshing;
        [RelayCommand]
        public async Task GetIslandGroupsAsync()
        {
            if (IsBusy) return;

            try
            {
                if (connectivity.NetworkAccess != NetworkAccess.Internet)
                {

                    await Shell.Current.DisplayAlert("Internet issue!",
                        $"Check your internet connection and try again!", "OK");
                    return;
                }

                IsBusy = true;
                var islandGroups = await islandGroupService.GetIslandGroups();

                if (IslandGroups.Count != 0)
                    IslandGroups.Clear();

                foreach (var islandGroup in islandGroups)
                    IslandGroups.Add(islandGroup);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!",
                    $"Unable to get islandGroups: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }
        }


        //[RelayCommand] // Hämta alla öar när man trycker på den knappen
        //async Task GetAllIslandsAsync()
        //{
           
        //}

        //[RelayCommand] // Hämta rätt öar för rätt ögrupp
        //async Task GetIslandsInIslandGroupAsync()
        //{

        //}

        [RelayCommand]
        async Task GetIslandGroupInfoAsync(IslandGroup islandGroups)
        {
            //var islandGroups = await islandGroupService.GetIslandGroups();
            //if (islandGroups.Count != 0)
            //    IslandGroups.Clear();

            //foreach (var islandGroup in islandGroups)
            //    IslandGroups.Add(islandGroup);
            if (islandGroups is null)
                return;

            await Shell.Current.DisplayAlert($"{islandGroups.Group}", $"{islandGroups.About}" , "Stäng");
        }

    }
}
