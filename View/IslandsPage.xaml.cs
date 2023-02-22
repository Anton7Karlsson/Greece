namespace Greece;

public partial class IslandsPage : ContentPage
{
	public IslandsPage(IslandsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}


}

