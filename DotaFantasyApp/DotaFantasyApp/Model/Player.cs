using System;
using System.Collections.Generic;
using System.Text;

namespace DotaFantasyApp.Model
{
    public class Player
    {
        public List<Ability> abilities { get; set; }
        public int assists { get; set; }
        public int camps_stacked { get; set; }
        public int creeps_stacked { get; set; }
        public object damage_taken { get; set; }
        public int deaths { get; set; }
        public int denies { get; set; }
        public string faction { get; set; }
        public int game_id { get; set; }
        public int gold_per_min { get; set; }
        public int gold_remaining { get; set; }
        public int gold_spent { get; set; }
        public int heal { get; set; }
        public Hero hero { get; set; }
        public int hero_damage { get; set; }
        public int hero_level { get; set; }
        public List<Item> items { get; set; }
        public int kills { get; set; }
        public int lane_creep { get; set; }
        public int last_hits { get; set; }
        public int neutral_creep { get; set; }
        public int observer_used { get; set; }
        public int observer_wards_destroyed { get; set; }
        public int observer_wards_purchased { get; set; }
        public Opponent2 opponent { get; set; }
        public Player2 player { get; set; }
        public int sentry_used { get; set; }
        public int sentry_wards_destroyed { get; set; }
        public int sentry_wards_purchased { get; set; }
        public Team team { get; set; }
        public int team_id { get; set; }
        public int tower_damage { get; set; }
        public int tower_kills { get; set; }
        public int xp_per_min { get; set; }
    }

    public class Player2
    {
        public string first_name { get; set; }
        public string hometown { get; set; }
        public int id { get; set; }
        public string image_url { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string slug { get; set; }
    }
}
