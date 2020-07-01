using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Elevation.Client.Common.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxAsyncCommand NewGameCommand { get; }

        public MainMenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            NewGameCommand = new MvxAsyncCommand(StartNewGame);
        }

        private async Task StartNewGame()
        {
            await _navigationService.Navigate<GameViewModel>();
        }
    }
}
