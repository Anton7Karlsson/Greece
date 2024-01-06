namespace Greece;

public partial class IslandGroupsPage : ContentPage
{
    public IslandGroupsPage(IslandGroupsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}