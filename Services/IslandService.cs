using Greece.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace Greece.Services
{
    public class IslandService
    {
        HttpClient httpClient;
        public IslandService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Island>> GetIslands()
        {
            //var url = "https://github.com/Anton7Karlsson/app/blob/main/Islands.json";

            //var response = await httpClient.GetAsync(url);

            var stream = await FileSystem.OpenAppPackageFileAsync("IslandGroups.json");
            var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            var islandList = JsonSerializer.Deserialize<List<IslandGroup>>(contents);
          
            var result = islandList.SelectMany(o => o.Islands).ToList();

            return result;
        }
    }
}
