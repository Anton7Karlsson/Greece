using Android.App;


[assembly: UsesPermission(Android.Manifest.Permission.AccessCoarseLocation)]
[assembly: UsesPermission(Android.Manifest.Permission.AccessFineLocation)]
[assembly: UsesFeature("android.hardware.IslandGroup", Required = false)]
[assembly: UsesFeature("android.hardware.IslandGroup.gps", Required = false)]
[assembly: UsesFeature("android.hardware.IslandGroup.network", Required = false)]
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]