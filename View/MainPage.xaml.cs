namespace Greece;

public partial class MainPage : ContentPage
{
	public MainPage(IslandsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

	
}

