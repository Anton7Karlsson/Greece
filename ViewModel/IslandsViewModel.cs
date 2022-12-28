using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greece.Services;


namespace Greece.ViewModel
{
    public partial class IslandsViewModel : BaseViewModel
    {
        IslandService islandService;
        public ObservableCollection<Island> Islands { get; } = new();

        public IslandsViewModel(IslandService islandService)
        {
            Title = "Greek Islands";
            this.islandService = islandService;

        }

        [RelayCommand]
        async Task GetIslandsAsync()
        {
            if (IsBusy) return;

            try
            {
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
