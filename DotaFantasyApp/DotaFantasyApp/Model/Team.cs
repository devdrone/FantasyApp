using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Team
    {
        public List<int> bans { get; set; }
        public BarracksStatus barracks_status { get; set; }
        public string faction { get; set; }
        public bool first_blood { get; set; }
        public List<int> picks { get; set; }
        public List<int> player_ids { get; set; }
        public int score { get; set; }
        public TeamData team { get; set; }
        public TowerStatus tower_status { get; set; }
    }

    public class TeamData
    {
        public string acronym { get; set; }
        public int id { get; set; }
        public string image_url { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class BarracksStatus
    {
        public bool bottom_melee { get; set; }
        public bool bottom_ranged { get; set; }
        public bool middle_melee { get; set; }
        public bool middle_ranged { get; set; }
        public bool top_melee { get; set; }
        public bool top_ranged { get; set; }
    }

    public class TowerStatus
    {
        public bool ancient_bottom { get; set; }
        public bool ancient_top { get; set; }
        public bool bottom_tier_1 { get; set; }
        public bool bottom_tier_2 { get; set; }
        public bool bottom_tier_3 { get; set; }
        public bool middle_tier_1 { get; set; }
        public bool middle_tier_2 { get; set; }
        public bool middle_tier_3 { get; set; }
        public bool top_tier_1 { get; set; }
        public bool top_tier_2 { get; set; }
        public bool top_tier_3 { get; set; }
    }
}
