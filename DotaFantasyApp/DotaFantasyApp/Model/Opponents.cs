using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Opponents
    {
        public Opponent2 opponent { get; set; }
        public string type { get; set; }
    }

    public class Opponent2
    {
        public string acronym { get; set; }
        public int id { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }
}
