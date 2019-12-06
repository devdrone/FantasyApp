using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Player2
    {
        private double _assists;
        private double _camps_stacked;
        private double _creep_stacked;
        private double _damage_taken;
        private double _deaths;
        private double _denies;
        private double _gpm;
        private double _gold_remaining;
        private double _gold_spent;
        private double _heal;
        private double _kills;
        private double _last_hit;
        private double _tower_damage;
        private double _tower_kills;
        private double _xp;

        public string first_name { get; set; }
        public string hometown { get; set; }
        public int id { get; set; }
        public string image_url { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string slug { get; set; }
        public double Assists { get { return _assists; } set { _assists = value; } }
        public double Camps_stacked { get { return _camps_stacked; } set { _camps_stacked = value * 0.25; } }
        public double Creeps_stacked { get { return _creep_stacked; } set { _creep_stacked = value * 0.10; } }
        public double Damage_taken { get { return _damage_taken; } set { _damage_taken = value * -2.5; } }
        public double Deaths { get { return _deaths; } set { _deaths = value * -10; } }
        public double Denies { get { return _denies; } set { _denies = value * 0.25; } }
        public double Gold_per_min { get { return _gpm; } set { _gpm = value * 0.02; } }
        public double Gold_remaining { get { return _gold_remaining; } set { _gold_remaining = value * 0.05; } }
        public double Gold_spent { get { return _gold_spent; } set { _gold_spent = value * 0.05; } }
        public double Heal { get { return _heal; } set { _heal = value * 0.1; } }
        public double Kills { get { return _kills; } set { _kills = value * 5; } }
        public double Last_hits { get { return _last_hit; } set { _last_hit = value * 0.5; } }
        public double Team_id { get; set; }
        public double Tower_damage { get { return _tower_damage; } set { _tower_damage = value * 0.05; } }
        public double Tower_kills { get { return _tower_kills; } set { _tower_kills = value * 0.5; } }
        public double Xp_per_min { get { return _xp; } set { _xp = value * 0.1; } }
    }
}
