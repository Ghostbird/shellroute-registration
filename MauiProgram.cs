namespace ShellRouteRegistration;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
		Routing.RegisterRoute("main", typeof(MainPage));
		builder.Services.AddSingleton<MainPage>().AddSingleton<MainPageViewModel>();
		return builder.Build();
	}
}
