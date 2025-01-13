using Foundation;

namespace MauiBinding
{
    [Register("AppDelegate")]
    public class AppDelegate: MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
