using Foundation;
using PXKit;

namespace PXBlazor;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    [Export("application:openURL:options:")]
    override public bool OpenUrl(UIKit.UIApplication app, NSUrl url, NSDictionary options)
    {
        if (url != null)
        {
            GainsightPX.Shared.EnterEditingModeWithUrl(url);
        }
        return true;
    }
}

