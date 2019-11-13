using System.Collections.Generic;
using DotaFantasyApp.Model;
using DotaFantasyApp.Utils;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace DotaFantasyApp.ViewModels
{
    public class MatchListViewModel : BindableBase
    {
        private List<UpcomingMatches> _matches;
        public static UpcomingMatches _selectedMatch;
        public INavigationService NavigationService { get; }
        public DelegateCommand MatchSelectCommand { get; private set; }
        public List<UpcomingMatches> Matches
        {
            get { return _matches; }
            set { SetProperty(ref _matches, value); RaisePropertyChanged(); }
        }
        public UpcomingMatches SelectedMatch
        {
            get
            {
                if (_selectedMatch == null)
                    _selectedMatch = new UpcomingMatches();
                return _selectedMatch;
            }
            set
            {
                SetProperty(ref _selectedMatch, value);
            }
        }

        public MatchListViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            MatchSelectCommand = new DelegateCommand(MatchSelect);
            GetMatch();
        }

        private void MatchSelect()
        {
            NavigationService.NavigateAsync("CreateTeam");
        }

        private void GetMatch()
        {
            List<KeyValuePair<string, string>> valuePairs = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> valuePair = new KeyValuePair<string, string>("status", "finished");
            valuePairs.Add(valuePair);
            Matches = ThinkDb<UpcomingMatches>.GetAllData("Matches", valuePairs);
        }
    }
}
