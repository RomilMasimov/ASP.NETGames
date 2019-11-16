using ASP.NETGames.Infrastructure.JsonConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class Game
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }

        [JsonConverter(typeof(ShortDateJsonConverter))]
        public DateTime? released { get; set; }
        public bool tba { get; set; }
        public string background_image { get; set; }
        public float rating { get; set; }
        public int rating_top { get; set; }
        public IEnumerable<Rating> ratings { get; set; }
        public int added { get; set; }
        public AddedByStatus added_by_status { get; set; }
        public int playtime { get; set; }
        public IEnumerable<PlatformForGame> platforms { get; set; }
        public IEnumerable<Store> stores { get; set; }
        public int ratings_count { get; set; }
        public int reviews_text_count { get; set; }
        public int? metacritic { get; set; }
        public int suggestions_count { get; set; }
        public Clip clip { get; set; }
        public object user_game { get; set; }
        public int reviews_count { get; set; }
        public string saturated_color { get; set; }
        public string dominant_color { get; set; }
        public IEnumerable<Screenshots> short_screenshots { get; set; }
        public IEnumerable<PlatformForGame> parent_platforms { get; set; }
        public IEnumerable<Genre> genres { get; set; }
        public int community_rating { get; set; }
    }
}
