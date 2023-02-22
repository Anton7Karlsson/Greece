namespace Greece.View;

public partial class IslandGroupsPage : ContentPage
{
    public IslandGroupsPage(IslandGroupsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }


    
}