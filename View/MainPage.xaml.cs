namespace Greece.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void ButtonToIslandGroup(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(IslandGroupsPage));
    }

    private async void ButtonToIslands(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(IslandsPage));
    }
}