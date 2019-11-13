using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Serie
    {
        public DateTime begin_at { get; set; }
        public object description { get; set; }
        public DateTime end_at { get; set; }
        public string full_name { get; set; }
        public int id { get; set; }
        public int league_id { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public string prizepool { get; set; }
        public object season { get; set; }
        public string slug { get; set; }
        public object winner_id { get; set; }
        public object winner_type { get; set; }
        public int year { get; set; }
    }
}
