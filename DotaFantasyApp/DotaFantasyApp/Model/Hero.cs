using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Hero
    {
        public int id { get; set; }
        public string image_url { get; set; }
        public string localized_name { get; set; }
        public string name { get; set; }
    }
}
