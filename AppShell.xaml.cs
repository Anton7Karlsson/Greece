using Greece.View;

namespace Greece;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(IslandsPage), typeof(IslandsPage));
		Routing.RegisterRoute(nameof(IslandGroupsPage), typeof(IslandGroupsPage));
		Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
		Routing.RegisterRoute(nameof(GroupDetailsPage), typeof(GroupDetailsPage));
	}
}
