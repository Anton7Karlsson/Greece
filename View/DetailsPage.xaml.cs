namespace Greece.View;

public partial class DetailsPage : ContentPage
{
	
	public DetailsPage(IslandsDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}