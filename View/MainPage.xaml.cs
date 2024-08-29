using static System.Net.WebRequestMethods;

namespace Greece.View;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Island> Islands { get; set; }
	public MainPage()
	{
        InitializeComponent();
        InitializeIslands();
        BindingContext = this;
	}

    private void InitializeIslands()
    {
        Islands = new ObservableCollection<Island>
        {
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/merakos_03_zakynthos-navagio_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1750x680/jpg/files/s_140094709_beaches-chania-elafonisi_1750x680.webp"},
            new Island { Image = "https://www.visitgreece.gr/images/1750x680/jpg/files/s_1119863444_beaches-rhodes_1750x680.webp"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/i_1225938906_milos-mandrakia_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/i_495291298_milos-kleftiko_1743x752.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/merakos_001_skiathos-hora_1743x752.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/merakos_001_skiathos-lalaria_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/s_1127769038_thasos_1743x752.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/i_147759322_thasos_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/s_75292516_kerkyra-aggeorgios_1743x752.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/i_635764444_corfu-palaiokastritsa_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/i_635764444_corfu-palaiokastritsa_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/merakos_01_kefalonia-assos_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/769x769/1/jpg/files/merakos_05_kefalonia-assos_769x769.webp"},
            new Island { Image = "https://www.visitgreece.gr/images/1310x769/1/jpg/files/s_326882015_lefkada-portokatsiki_1310x769.jpg"},
            new Island { Image = "https://www.visitgreece.gr/images/769x769/1/jpg/files/s_779755510_lefkada_769x769.webp"}
        };
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