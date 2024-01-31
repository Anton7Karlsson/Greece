namespace Greece;

public partial class GroupDetailsPage : ContentPage
{
	public GroupDetailsPage(GroupDetailsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

}