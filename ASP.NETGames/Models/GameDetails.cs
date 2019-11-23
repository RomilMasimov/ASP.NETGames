using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{

    public class GameDetails
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }
        public int? metacritic { get; set; }
        public string released { get; set; }
        public bool tba { get; set; }
        public DateTime updated { get; set; }
        public string background_image { get; set; }
        public string background_image_additional { get; set; }
        public string website { get; set; }
        public float rating { get; set; }
        public int? rating_top { get; set; }
        public IEnumerable<Rating> ratings { get; set; }
        public Dictionary<Reactions, int> reactions { get; set; }
        //public Reactions reactions { get; set; }
        public int? added { get; set; }
        public AddedByStatus added_by_status { get; set; }
        public int? playtime { get; set; }
        public int? screenshots_count { get; set; }
        public int? movies_count { get; set; }
        public int? creators_count { get; set; }
        public int? achievements_count { get; set; }
        public int? parent_achievements_count { get; set; }
        public string reddit_url { get; set; }
        public string reddit_name { get; set; }
        public string reddit_description { get; set; }
        public string reddit_logo { get; set; }
        public int? reddit_count { get; set; }
        public int? twitch_count { get; set; }
        public int? youtube_count { get; set; }
        public int? reviews_text_count { get; set; }
        public int? ratings_count { get; set; }
        public int? suggestions_count { get; set; }
        public IEnumerable<string> alternative_names { get; set; }
        public string metacritic_url { get; set; }
        public int? parents_count { get; set; }
        public int? additions_count { get; set; }
        public int? game_series_count { get; set; }
        public object user_game { get; set; }
        public int? reviews_count { get; set; }
        public string saturated_color { get; set; }
        public string dominant_color { get; set; }
        public IEnumerable<PlatformForGame> parent_platforms { get; set; }
        public IEnumerable<PlatformForGame> platforms { get; set; }
        public IEnumerable<StoreForGame> stores { get; set; }
        public IEnumerable<Developer> developers { get; set; }
        public IEnumerable<Genre> genres { get; set; }
        public IEnumerable<Tag> tags { get; set; }
        public IEnumerable<Publisher> publishers { get; set; }
        public EsrbRating esrb_rating { get; set; }
        public Clip clip { get; set; }
        public IEnumerable<Screenshots> screenshots { get; set; }
        public string description_raw { get; set; }
    }
}
