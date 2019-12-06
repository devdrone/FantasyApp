using DotaFantasyApp.Model;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.Generic;

namespace DotaFantasyApp.ViewModels
{
    public class CreateTeamViewModel : BindableBase
    {
        private INavigationService NavigationService;
        private List<Player2> _players;

        public string Name { get { return MatchListViewModel._selectedMatch.Name; } }
        public string ImageUrl1 { get { return MatchListViewModel._selectedMatch.ImageUrl1; } }
        public string ImageUrl2 { get { return MatchListViewModel._selectedMatch.ImageUrl2; } }
        public string Team1 { get { return MatchListViewModel._selectedMatch.Team1.name; } }
        public string Team2 { get { return MatchListViewModel._selectedMatch.Team2.name; } }
        public List<Player2> Players
        {
            get
            {
                return _players;
            }
            set
            {
                SetProperty(ref _players, value);
                RaisePropertyChanged("Players");
            }
        }

        public CreateTeamViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            //Players = new List<Player2>();
            //Players.InsertRange(Players.Count, MatchListViewModel._selectedMatch.Team1.players);
            //Players.InsertRange(Players.Count + 1, MatchListViewModel._selectedMatch.Team2.players);
            GetPlayers();
        }

        private void GetPlayers()
        {
            if (Players == null)
            {
                Players = new List<Player2>();
                Players.InsertRange(Players.Count, MatchListViewModel._selectedMatch.Team1.players);
            }
            if (Players.Count >= 5 && Players.Count < MatchListViewModel._selectedMatch.Team1.players.Count + MatchListViewModel._selectedMatch.Team2.players.Count)
                Players.InsertRange(Players.Count, MatchListViewModel._selectedMatch.Team2.players);
        }
    }
}
