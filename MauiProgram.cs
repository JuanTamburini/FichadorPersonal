using FichadorPersonal.View;
using FichadorPersonal.ViewModel;

namespace FichadorPersonal;

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
		//TODO: Entender mejor esto:

		//MainPage
		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<MainPage>();

		//RegisterFormPage
		builder.Services.AddTransient<RegisterFormPage>();

		return builder.Build();
	}
}
