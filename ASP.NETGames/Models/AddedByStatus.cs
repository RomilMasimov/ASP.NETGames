using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class AddedByStatus
    {
        [JsonPropertyName("yet")]
        public int Yet { get; set; }
        
        [JsonPropertyName("owned")]
        public int Owned { get; set; }
        
        [JsonPropertyName("beaten")]
        public int Beaten { get; set; }
        
        [JsonPropertyName("toplay")]
        public int ToPlay { get; set; }
        
        [JsonPropertyName("dropped")]
        public int Dropped { get; set; }
        
        [JsonPropertyName("playing")]
        public int Playing { get; set; }
    }
}