using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Model;
using MonkeyFinder.Services;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MonkeyFinder.ViewModel;

public partial class MonkeysViewModel : BaseViewModel
{
    private readonly MonkeyService monkeyService;
    private readonly IGeolocation geolocation;

    public MonkeysViewModel(MonkeyService monkeyService, IGeolocation geolocation)
    {
        Title = "Monkey Finder";
        this.monkeyService = monkeyService;
        this.geolocation = geolocation;
    }

    public ObservableCollection<Monkey> Monkeys { get; } = new();

    [ICommand]
    public async Task GetMonkeysAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;

            List<Monkey> monkeys = await monkeyService.GetMonkeys();

            Monkeys.Clear();
            foreach (Monkey monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to get monkeys: {ex.Message}");
            await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }

    [ICommand]
    public async Task GetClosestMonkeyAsync()
    {
        if (IsBusy || Monkeys.Count == 0)
        {
            return;
        }

        try
        {
            // Get cached location, else get real location.
            Location location = await geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });
            }

            // Find closest monkey to us
            Monkey first = Monkeys.OrderBy(m => location.CalculateDistance(
                new Location(m.Latitude, m.Longitude), DistanceUnits.Miles))
                .FirstOrDefault();

            await Application.Current.MainPage.DisplayAlert("", first.Name + " " +
                first.Location, "OK");

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to query location: {ex.Message}");
            await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
        }
    }

    [ObservableProperty]
    private bool isRefreshing;
}
