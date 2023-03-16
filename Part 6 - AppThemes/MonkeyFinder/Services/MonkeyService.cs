using System.Net.Http.Json;

namespace MonkeyFinder.Services;

public class MonkeyService
{
    HttpClient httpClient;
    public MonkeyService()
    {
        this.httpClient = new HttpClient();
    }

    List<Country> countryList;
    public async Task<List<Country>> GetMonkeys()
    {
        if (countryList?.Count > 0)
            return countryList;

        // Online
        /*var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }*/

        // Offline
        using var stream = await FileSystem.OpenAppPackageFileAsync("countries.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        countryList = JsonSerializer.Deserialize<List<Country>>(contents);

        return countryList;
    }
}
