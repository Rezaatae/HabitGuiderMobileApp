using HabitGuiderMobileApp.Data;
using HabitGuiderMobileApp.ViewModels;
using HabitGuiderMobileApp.Views;
using Microsoft.Extensions.Logging;

namespace HabitGuiderMobileApp;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<DatabaseContext>();

        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HabitsListViewModel>();
        builder.Services.AddSingleton<NewHabitViewModel>();

        builder.Services.AddSingleton<HomeView>();
		builder.Services.AddSingleton<HabitsListView>();
		builder.Services.AddSingleton<NewHabitView>();

		return builder.Build();
	}
}
