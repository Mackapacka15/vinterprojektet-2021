using System;
using System.Text.Json.Serialization;

namespace vinterprojektet
{
    public class GrovaKort : Kort
    {
        [JsonPropertyName("grovLvl")]
        public int GrovLvl { get; init; }
    }
}