using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Content;
using Com.Gainsight.PX.Mobile;
using static Microsoft.Maui.ApplicationModel.Platform;

namespace PXBlazor;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Android.Content.Intent.ActionView },
         Categories = new[] { Android.Content.Intent.CategoryBrowsable, Android.Content.Intent.CategoryDefault },
          DataScheme = "gainsight.px.efdw8rwajtal")]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnNewIntent(Android.Content.Intent intent)
    {
        base.OnNewIntent(intent);
        if ((null != intent) && (null != intent.Data))
        {
            GainsightPX.With().EnterEditingMode(intent);
        }
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Android.Content.Intent intent = this.Intent;
        if ((null != intent) && (null != intent.Data))
        {
            GainsightPX.With().EnterEditingMode(intent);
        }
    }
}

