using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ASP.NETGames.Infrastructure.JsonConverters;

namespace ASP.NETGames.Models
{
    public class Game
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("released")]
        [JsonConverter(typeof(ShortDateJsonConverter))]
        public DateTime? ReleasedDate { get; set; }
        
        [JsonPropertyName("tba")]
        public bool TBA { get; set; }
        
        [JsonPropertyName("background_image")]
        public string BackgroundImage { get; set; }
        
        [JsonPropertyName("rating")]
        public float Rating { get; set; }
        
        [JsonPropertyName("rating_top")]
        public int RatingTop { get; set; }
        
        [JsonPropertyName("ratings")]
        public IEnumerable<Rating> Ratings { get; set; }
        
        [JsonPropertyName("added")]
        public int Added { get; set; }
        
        [JsonPropertyName("added_by_status")]
        public AddedByStatus AddedByStatus { get; set; }
        
        [JsonPropertyName("playtime")]
        public int Playtime { get; set; }
        
        [JsonPropertyName("platforms")]
        public IEnumerable<PlatformForGame> Platforms { get; set; }
        
        [JsonPropertyName("stores")]
        public IEnumerable<Store> Stores { get; set; }
        
        [JsonPropertyName("ratings_count")]
        public int RatingsCount { get; set; }
        
        [JsonPropertyName("reviews_text_count")]
        public int ReviewsTextCount { get; set; }
        
        [JsonPropertyName("metacritic")]
        public int? Metacritic { get; set; }
        
        [JsonPropertyName("suggestions_count")]
        public int SuggestionsCount { get; set; }
        
        [JsonPropertyName("clip")]
        public Clip Clip { get; set; }
        
        [JsonPropertyName("user_game")]
        public object UserGame { get; set; }
        
        [JsonPropertyName("reviews_count")]
        public int ReviewsCount { get; set; }
        
        [JsonPropertyName("saturated_color")]
        public string SaturatedColor { get; set; }
        
        [JsonPropertyName("dominant_color")]
        public string DominantColor { get; set; }
        
        [JsonPropertyName("short_screenshots")]
        public IEnumerable<Screenshots> ShortScreenshots { get; set; }
        
        [JsonPropertyName("parent_platforms")]
        public IEnumerable<PlatformForGame> ParentPlatforms { get; set; }
        
        [JsonPropertyName("genres")]
        public IEnumerable<Genre> Genres { get; set; }
        
        [JsonPropertyName("community_rating")]
        public int CommunityRating { get; set; }
    }
}
