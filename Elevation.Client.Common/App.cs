using Elevation.Client.Common.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elevation.Client.Common
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<MainMenuViewModel>();
        }
    }
}
