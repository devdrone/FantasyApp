using System;
using System.Collections.Generic;

namespace DotaFantasyApp.Model
{
    public class UpcomingMatches
    {
        public class League
        {
            public int id { get; set; }
            public string image_url { get; set; }
            public string name { get; set; }
        }

        public class Opponent2
        {
            public string acronym { get; set; }
            public int id { get; set; }
            public string image_url { get; set; }
            public string name { get; set; }
        }

        public class Opponent
        {
            public Opponent2 opponent { get; set; }
        }

        public class Serie
        {
            public string full_name { get; set; }
            public int id { get; set; }
            public object prizepool { get; set; }
            public string season { get; set; }
            public int year { get; set; }
        }

        public class Tournament
        {
            public int id { get; set; }
            public int league_id { get; set; }
            public string name { get; set; }
        }
        public DateTime begin_at { get; set; }
        public int id { get; set; }
        public string ImageUrl1 { get { return opponents[0].opponent.image_url; } }
        public string ImageUrl2 { get { return opponents[1].opponent.image_url; } }
        public League league { get; set; }
        public string match_type { get; set; }
        public string name { get; set; }
        public int number_of_games { get; set; }
        public List<Opponent> opponents { get; set; }
        public Serie serie { get; set; }
        public string status { get; set; }
        public Tournament tournament { get; set; }
        public int tournament_id { get; set; }
        public object winner_id { get; set; }
        public string Name { get { return league.name + " " + serie.year + " " + NameCheck.Check(name); } }
    }

    public static class NameCheck
    {
        public static string Check(string data)
        {
            if (data.Contains(":"))
                return data.Substring(0, data.IndexOf(":"));
            else
                return data;
        }
    }
}
