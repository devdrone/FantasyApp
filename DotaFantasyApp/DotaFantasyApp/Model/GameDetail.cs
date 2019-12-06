using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class GameDetail
    {
        public DateTime begin_at { get; set; }
        public bool detailed_stats { get; set; }
        public DateTime end_at { get; set; }
        public bool finished { get; set; }
        public object first_blood { get; set; }
        public bool forfeit { get; set; }
        public int id { get; set; }
        public int length { get; set; }
        public UpcomingMatches match { get; set; }
        public int match_id { get; set; }
        public List<Player2> players { get; set; }
        public int position { get; set; }
        public string status { get; set; }
        public List<Team> teams { get; set; }
        public object video_url { get; set; }
        public Winner winner { get; set; }
        public string winner_type { get; set; }
    }
}
