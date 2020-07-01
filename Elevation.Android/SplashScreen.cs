
using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace Elevation.Android
{
    [Activity(Label = "Elevation", MainLauncher = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
               : base(Resource.Layout.splash_screen)
        {
        }
    }
}