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
            var stream = await FileSystem.OpenAppPackageFileAsync("Islands.json");
            var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            var islandList = JsonSerializer.Deserialize<List<Island>>(contents);
          
            var result = islandList.ToList();

            return result;
        }
    }
}
