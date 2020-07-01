using Elevation.Core.ViewModels;
using MvvmCross.ViewModels;

namespace Elevation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainMenuViewModel>();
        }
    }
}
