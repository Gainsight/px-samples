# Installation:

### iOS Bridge:

1. Install sharpie (https://learn.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started)

2. Use the command below to create a binding for PXKit.xcfrmework in Sharpie.

```
sharpie bind --sdk=iphoneosx.x --output="XamarinApiDef" --namespace="PXKit" --scope="PXKit.xcframework/ios-arm64/Headers/" "PXKit.xcframework/ios-arm64/Headers/PXKit-Swift.h"
```

3. With the Visual Studio "iOS Binding Library" template, create a binding library for the iOS framework. To reference, click the link below from the section under "Create a binding library.".
   https://learn.microsoft.com/en-us/xamarin/ios/platform/binding-swift/walkthrough#build-a-binding-library

4. In the application dependencies, use the dll from the build output.

### Android Bridge:

1. Download the Android aar file.

2. Build Binding Library for Android framework using Visual Studio "Android Java Library Binding" template. To learn more, click the link below.
   https://learn.microsoft.com/en-us/xamarin/android/platform/binding-java-library/

3. In the application dependencies, use the dll from the build output.

> Usage:

## Note: 
##    1. Update "AP-XXXXXXXXXX-3" in project, with your product tag-key provided in GainsightPX Dashboard under Administration/Setup/Products.
##    2. Update "gainsight.px.xxxxxxxxxx" in project, with your scheme provided in GainsightPX Dashboard under Administration/Setup/Products. 


We must give the webview instance to the SDK since Maui Blazor loads the application using HTML before we can begin tracking events.

1. Add the iOS and Android dlls as dependencies to the project from the aforementioned section.
2. Add the framework as displayed below.

```
#if IOS
using PXKit;
#elif ANDROID
using Com.Gainsight.PX.Mobile;
#endif
```

3. Provide the webview to PXKit as shown below

```
    ...
blazorWebView.BlazorWebViewInitialized += (one, two) => {
#if IOS
        GainsightPX.Shared.StartTrackingWithWebview(two.WebView);
#elif ANDROID
          GainsightPX.AttachToWebView(two.WebView);
 #endif
    }
    ...
```

4. Now you can use PXKit in your JS using `window.gainsight.`

5. All the api's in JS to access through `window.gainsight.` are providied in below documentation.
   https://support.gainsight.com/PX/Mobile/01Getting_Started/Install_Gainsight_PX/07_Gainsight_PX_Hybrid_Mobile_SDK

6. This is an example code, that is injected into HTML using a razor file.


```
@page "/"
@inject IJSRuntime JS
<h1>Hello, world!</h1>

Welcome to your new app.

<SurveyPrompt Title="How is Blazor working for you?" />

<button id="gpx_init" class="btn btn-primary" @onclick="GPXInit">GPX Init</button>

<button id="gpx_identify" class="btn btn-primary" @onclick="GPXIdentify">GPX Identify</button>

<button class="btn btn-primary" id="cEvent_button" @onclick="CustomEvent">Custom Event</button>

@code {

    private async void GPXInit()
    {
        try
        {
            Dictionary<string, object> config = new Dictionary<string, object>();
            config.Add("enabled", true);
            config.Add("apiKey", "AP-XXXXXXXXXX-3");
            config.Add("shouldTrackPages", true);
            config.Add("shouldTrackTapEvents", true);
            await JS.InvokeVoidAsync("window.gainsightpx.initialize", config);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }

    private async void GPXIdentify()
    {
        try
        {
#if IOS
        await JS.InvokeVoidAsync("window.gainsightpx.identifyWithID", "Balzor_ios_user");
#elif ANDROID
        await JS.InvokeVoidAsync("window.gainsightpx.identifyWithID", "Balzor_android_user");
#endif
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
    
    private async void CustomEvent()
    {
        try
        {
            Dictionary<string, object> cevent = new Dictionary<string, object>();
            cevent.Add("eventName", "purchase_success");
            cevent.Add("properties", null);
            await JS.InvokeVoidAsync("window.gainsightpx.customEvent", cevent);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
```
