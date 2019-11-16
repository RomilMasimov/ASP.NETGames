using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP.NETGames.Models
{
    public class Clip
    {
        public string clip { get; set; }
        public Dictionary<ClipResolution, string> clips { get; set; }
        //public Clips clips { get; set; }
        public string video { get; set; }
        public string preview { get; set; }
    }

    public enum ClipResolution
    {
        _320,
        _640,
        full
    }
}
