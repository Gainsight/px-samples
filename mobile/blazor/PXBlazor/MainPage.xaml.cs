namespace PXBlazor;
#if IOS
using PXKit;
#elif ANDROID
using Android.Content;
using Com.Gainsight.PX.Mobile;
#endif

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		blazorWebView.BlazorWebViewInitialized += (one, two) =>
		{
#if IOS
            GainsightPX.Shared.StartTrackingWithWebview(two.WebView);
#elif ANDROID
            GainsightPX.AttachToWebView(two.WebView);
#endif
        };
	}
}

