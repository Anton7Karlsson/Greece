using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Greece.Services
{
    public class IslandGroupService
    {
        HttpClient httpClient;
        public IslandGroupService()
        {
            httpClient = new HttpClient();
        }

        List<IslandGroup> islandGroupList = new();
        public async Task<List<IslandGroup>> GetIslandGroups()
        {
            if (islandGroupList?.Count > 0) return islandGroupList;

            using var stream = await FileSystem.OpenAppPackageFileAsync("IslandGroups.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            islandGroupList = JsonSerializer.Deserialize<List<IslandGroup>>(contents);

            return islandGroupList;
        }

    }
}
