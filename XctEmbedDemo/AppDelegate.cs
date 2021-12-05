using Foundation;
using UIKit;
using Xamarin.Forms;
using XctEmbedDemo;

public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow Window
    {
        get;
        set;
    }

    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
        Forms.Init();

        // Create app-level resource dictionary.
        Xamarin.Forms.Application.Current = new Xamarin.Forms.Application
        {
            MainPage = new Page()
        };
        Xamarin.Forms.Application.Current.Resources = new ResourceDictionary();

        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        var mainViewController = new MainViewController();
        var navController = new UINavigationController(mainViewController);
        Window.RootViewController = navController;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}