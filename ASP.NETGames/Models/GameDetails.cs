using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ASP.NETGames.Models
{

    public class GameDetails
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("name_original")]
        public string NameOriginal { get; set; }
        
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("metacritic")]
        public int? Metacritic { get; set; }
        
        [JsonPropertyName("released")]
        public string Released { get; set; }
        
        [JsonPropertyName("tba")]
        public bool TBA { get; set; }
        
        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }
        
        [JsonPropertyName("background_image")]
        public string BackgroundImage { get; set; }
        
        [JsonPropertyName("background_image_additional")]
        public string BackgroundImageAdditional { get; set; }
        
        [JsonPropertyName("website")]
        public string WebsiteUrl { get; set; }
        
        [JsonPropertyName("rating")]
        public float Rating { get; set; }
        
        [JsonPropertyName("rating_top")]
        public int? RatingTop { get; set; }
        
        [JsonPropertyName("ratings")]
        public IEnumerable<Rating> Ratings { get; set; }
        
        [JsonPropertyName("reactions")]
        public Dictionary<Reactions, int> Reactions { get; set; }
        
        [JsonPropertyName("added")]
        public int? Added { get; set; }
        
        [JsonPropertyName("added_by_status")]
        public AddedByStatus AddedByStatus { get; set; }
        
        [JsonPropertyName("playtime")]
        public int? Playtime { get; set; }
        
        [JsonPropertyName("screenshots_count")]
        public int? ScreenshotsCount { get; set; }
        
        [JsonPropertyName("movies_count")]
        public int? MoviesCount { get; set; }
        
        [JsonPropertyName("creators_count")]
        public int? CreatorsCount { get; set; }
        
        [JsonPropertyName("achievements_count")]
        public int? AchievementsCount { get; set; }
        
        [JsonPropertyName("parent_achievements_count")]
        public int? ParentAchievementsCount { get; set; }
        
        [JsonPropertyName("reddit_url")]
        public string RedditUrl { get; set; }
        
        [JsonPropertyName("reddit_name")]
        public string RedditName { get; set; }
        
        [JsonPropertyName("reddit_description")]
        public string RedditDescription { get; set; }
        
        [JsonPropertyName("reddit_logo")]
        public string RedditLogo { get; set; }
        
        [JsonPropertyName("reddit_count")]
        public int? RedditCount { get; set; }
        
        [JsonPropertyName("twitch_count")]
        public int? TwitchCount { get; set; }
        
        [JsonPropertyName("youtube_count")]
        public int? YoutubeCount { get; set; }
        
        [JsonPropertyName("reviews_text_count")]
        public int? ReviewsTextCount { get; set; }
        
        [JsonPropertyName("ratings_count")]
        public int? RatingsCount { get; set; }
        
        [JsonPropertyName("suggestions_count")]
        public int? SuggestionsCount { get; set; }
        
        [JsonPropertyName("alternative_names")]
        public IEnumerable<string> AlternativeNames { get; set; }
        
        [JsonPropertyName("metacritic_url")]
        public string MetacriticUrl { get; set; }
        
        [JsonPropertyName("parents_count")]
        public int? ParentsCount { get; set; }
        
        [JsonPropertyName("additions_count")]
        public int? AdditionsCount { get; set; }
        
        [JsonPropertyName("game_series_count")]
        public int? GameSeriesCount { get; set; }
        
        [JsonPropertyName("user_game")]
        public object UserGame { get; set; }
        
        [JsonPropertyName("reviews_count")]
        public int? ReviewsCount { get; set; }
        
        [JsonPropertyName("saturated_color")]
        public string SaturatedColor { get; set; }
        
        [JsonPropertyName("dominant_color")]
        public string DominantColor { get; set; }
        
        [JsonPropertyName("parent_platforms")]
        public IEnumerable<PlatformForGame> ParentPlatforms { get; set; }
        
        [JsonPropertyName("platforms")]
        public IEnumerable<PlatformForGame> Platforms { get; set; }
        
        [JsonPropertyName("stores")]
        public IEnumerable<StoreForGame> Stores { get; set; }
        
        [JsonPropertyName("developers")]
        public IEnumerable<Developer> Developers { get; set; }
        
        [JsonPropertyName("genres")]
        public IEnumerable<Genre> Genres { get; set; }
        
        [JsonPropertyName("tags")]
        public IEnumerable<Tag> Tags { get; set; }
        
        [JsonPropertyName("publishers")]
        public IEnumerable<Publisher> Publishers { get; set; }
        
        [JsonPropertyName("esrb_rating")]
        public EsrbRating EsrbRating { get; set; }
        
        [JsonPropertyName("clip")]
        public Clip Clip { get; set; }
        
        [JsonPropertyName("screenshots")]
        public IEnumerable<Screenshots> Screenshots { get; set; }
        
        [JsonPropertyName("description_raw")]
        public string DescriptionRaw { get; set; }
    }
}
