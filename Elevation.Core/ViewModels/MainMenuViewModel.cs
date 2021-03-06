﻿using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Elevation.Core.ViewModels
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
