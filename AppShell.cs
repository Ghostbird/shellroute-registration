namespace ShellRouteRegistration;

public class AppShell : Shell
{
	public AppShell()
	{
		Items.Add(
			new ShellContent()
			{
				Title = "Error",
				Route = "error",
				ContentTemplate = new DataTemplate(() => new ContentPage()),
			}
		);
	}

	protected override async void OnAppearing()
	{
		await GoToAsync("/main");
	}
}
