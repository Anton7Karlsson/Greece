using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Greece.Services
{
    public class IslandService
    {
        HttpClient httpClient;
        public IslandService()
        {
            httpClient = new HttpClient();
        }
          


        List<Island> islandList = new ();
        public async Task<List<Island>> GetIslands()
        {
            if (islandList?.Count > 0) return islandList;

            //var url = "https://github.com/Anton7Karlsson/app/blob/main/Islands.json";

            //var response = await httpClient.GetAsync(url);

            using var stream = await FileSystem.OpenAppPackageFileAsync("Islands.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            islandList = JsonSerializer.Deserialize<List<Island>>(contents);

            //if(response.IsSuccessStatusCode)
            //{
            //    islandList = await response.Content.ReadFromJsonAsync<List<Island>>();
            //}

            return islandList;
        }
    }
}
