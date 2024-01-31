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
        IslandService islandService;
        public ObservableCollection<IslandGroup> IslandGroups { get;} = new();
        public ObservableCollection<Island> Islands { get; set; } = new();

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

        [RelayCommand]
        async Task GoToGroupDetailsAsync(IslandGroup islandGroup)
        {
            if (islandGroup is null)
                return;
            
                await Shell.Current.GoToAsync($"{nameof(GroupDetailsPage)}", true,
                new Dictionary<string, object>
                {
                    {"IslandGroup", islandGroup}
                });
        }

    }
}
