using Greece.Services;
using Greece.View;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace Greece;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

				fonts.AddFont("Brands-Regular-400.otf", "FAB");
				fonts.AddFont("Free-Regular-400.otf", "FAR");
				fonts.AddFont("Free-Solid-900.otf", "FAS");
			});



		builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
		builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
		builder.Services.AddSingleton<IMap>(Map.Default);

		builder.Services.AddSingleton<IslandService>();
		builder.Services.AddSingleton<IslandGroupService>();

		builder.Services.AddSingleton<IslandsViewModel>();
		builder.Services.AddTransient<IslandsDetailsViewModel>();
		builder.Services.AddSingleton<IslandGroupsViewModel>();
		builder.Services.AddTransient<GroupDetailsViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<IslandGroupsPage>();
		builder.Services.AddTransient<GroupDetailsPage>();
		builder.Services.AddSingleton<IslandsPage>();
		builder.Services.AddTransient<DetailsPage>();

		return builder.Build();
	}
}
