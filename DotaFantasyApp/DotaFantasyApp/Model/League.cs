using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class League
    {
        public int id { get; set; }
        public string image_url { get; set; }
        public bool live_supported { get; set; }
        public DateTime modified_at { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public object url { get; set; }
    }
}
