using System;
using DotaFantasyApp.Model;
using Prism.Mvvm;
using Prism.Navigation;

namespace DotaFantasyApp.ViewModels
{
    public class CreateTeamViewModel : BindableBase
    {
        private INavigationService NavigationService;

        public string Name { get { return MatchListViewModel._selectedMatch.Name; } }
        public string ImageUrl1 { get { return MatchListViewModel._selectedMatch.ImageUrl1; } }
        public string ImageUrl2 { get { return MatchListViewModel._selectedMatch.ImageUrl2; } }
        public string Team1 { get { return MatchListViewModel._selectedMatch.Team1; } }
        public string Team2 { get { return MatchListViewModel._selectedMatch.Team2; } }

        public CreateTeamViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
