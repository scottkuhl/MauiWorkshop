using MonkeyFinder.Services;
using MonkeyFinder.View;
using MonkeyFinder.ViewModel;

namespace MonkeyFinder;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                _ = fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                _ = fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        _ = builder.Services.AddSingleton<MainPage>();
        _ = builder.Services.AddSingleton<MonkeyService>();
        _ = builder.Services.AddSingleton<MonkeysViewModel>();

        _ = builder.Services.AddTransient<MonkeyDetailsViewModel>();
        _ = builder.Services.AddTransient<DetailsPage>();

        _ = builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        _ = builder.Services.AddSingleton<IMap>(Map.Default);

        return builder.Build();
    }
}