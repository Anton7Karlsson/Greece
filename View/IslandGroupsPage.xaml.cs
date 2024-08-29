namespace Greece;

public partial class IslandGroupsPage : ContentPage
{
    public IslandGroupsPage(IslandGroupsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    private async void GroupDetails(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(IslandGroupsPage));
    }
}