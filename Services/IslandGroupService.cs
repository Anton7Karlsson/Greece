using System;
using Greece.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace Greece.Services
{
    public class IslandGroupService
    {
        HttpClient httpClient;
        public IslandGroupService()
        {
            httpClient = new HttpClient();
        }

        //List<IslandGroup> islandGroupList = new();
        public async Task<List<IslandGroup>> GetIslandGroups()
        {
            //if (islandGroupList?.Count > 0) return islandGroupList;

            var stream = await FileSystem.OpenAppPackageFileAsync("IslandGroups.json");
            var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            var islandGroupList = JsonSerializer.Deserialize<List<IslandGroup>>(contents);

            var result = islandGroupList.ToList();

            return result;
        }

    }
}
