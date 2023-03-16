namespace MonkeyFinder.ViewModel;

[QueryProperty(nameof(Country), "Country")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{
    IMap map;
    public MonkeyDetailsViewModel(IMap map)
    {
        this.map = map;
    }

    [ObservableProperty]
    Country country;

    [RelayCommand]
    async Task OpenMap()
    {
        try
        {
            await map.OpenAsync(Country.latitude, Country.longitude, new MapLaunchOptions
            {
                Name = Country.name,
                NavigationMode = NavigationMode.None
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to launch maps: {ex.Message}");
            await Shell.Current.DisplayAlert("Error, no Maps app!", ex.Message, "OK");
        }
    }
}
