using System;
using System.Collections.Generic;
using DotaFantasyApp.Model;
using DotaFantasyApp.Utils;
using Prism.Mvvm;

namespace DotaFantasyApp.ViewModels
{
    public class MatchListViewModel : BindableBase
    {
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public List<UpcomingMatches> Matches
        {
            get { return _matches; }
            set { SetProperty(ref _matches, value); RaisePropertyChanged(); }
        }
        public List<KeyValuePair<string, string>> valuePairs = new List<KeyValuePair<string, string>>();
        KeyValuePair<string, string> valuePair = new KeyValuePair<string, string>("status", "finished");
        private List<UpcomingMatches> _matches;

        public MatchListViewModel()
        {
            GetMatch();
        }

        private void GetMatch()
        {
            valuePairs.Add(valuePair);
            Matches = ThinkDb<UpcomingMatches>.GetAllData("Matches", valuePairs);
        }
    }   
}
