
using Android.App;
using Android.OS;
using Elevation.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;

namespace Elevation.Android.Views
{
    [Activity(Label = "Elevation", MainLauncher = true)]
    [MvxViewFor(typeof(MainMenuViewModel))]
    public class MainMenuView : MvxActivity<MainMenuViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_menu);
        }
    }
}