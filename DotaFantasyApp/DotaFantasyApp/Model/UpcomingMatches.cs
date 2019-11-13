using System;
using System.Collections.Generic;

namespace DotaFantasyApp.Model
{
    public class UpcomingMatches
    {
        public DateTime begin_at { get; set; }
        public bool detailed_stats { get; set; }
        public bool draw { get; set; }
        public DateTime end_at { get; set; }
        public bool forfeit { get; set; }
        public List<Game> games { get; set; }
        public int id { get; set; }
        public League league { get; set; }
        public int league_id { get; set; }
        public Live live { get; set; }
        public object live_url { get; set; }
        public string match_type { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public int number_of_games { get; set; }
        public List<Opponents> opponents { get; set; }
        public DateTime scheduled_at { get; set; }
        public Serie serie { get; set; }
        public int serie_id { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
        public Tournament tournament { get; set; }
        public int tournament_id { get; set; }
        public Winner winner { get; set; }
        public int winner_id { get; set; }
        public string ImageUrl1 { get { return opponents[0].opponent.image_url; } }
        public string Team1 { get { return opponents[0].opponent.acronym; } }
        public string ImageUrl2 { get { return opponents[1].opponent.image_url; } }
        public string Team2 { get { return opponents[1].opponent.acronym; } }
        public string Name { get { return league.name + " " + serie.year + "-" + tournament.name; } }
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

    public class Live
    {
        public DateTime opens_at { get; set; }
        public bool supported { get; set; }
        public string url { get; set; }
    }
}
