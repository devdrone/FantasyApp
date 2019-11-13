using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Game
    {
        public object begin_at { get; set; }
        public bool detailed_stats { get; set; }
        public object end_at { get; set; }
        public bool finished { get; set; }
        public bool forfeit { get; set; }
        public int id { get; set; }
        public object length { get; set; }
        public int match_id { get; set; }
        public int position { get; set; }
        public string status { get; set; }
        public object video_url { get; set; }
        public Winner winner { get; set; }
        public object winner_type { get; set; }
    }
}
