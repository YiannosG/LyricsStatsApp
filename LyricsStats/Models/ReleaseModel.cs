using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace LyricsStats.Models
{    

   
    public class ReleaseGroup
    {
        public string disambiguation { get; set; }
        [JsonProperty("first-release-date")]
        public string FirstReleaseDate { get; set; }
        [JsonProperty("secondary-type-ids")]
        public List<string> SecondaryTypeIds { get; set; }
        [JsonProperty("primary-type")]
        public string PrimaryType { get; set; }
        public string title { get; set; }
        public string id { get; set; }
        [JsonProperty("secondary-types")]
        public List<string> SecondaryTypes { get; set; }
        [JsonProperty("primary-type-id")]
        public string PrimaryTypeId { get; set; }
    }

    public class ReleaseModel
    {
        [JsonProperty("release-group-count")]
        public int ReleaseGroupCount { get; set; }
        [JsonProperty("release-groups")]
        public List<ReleaseGroup> ReleaseGroups { get; set; }
        [JsonProperty("release-group-offset")]
        public int ReleaseGroupOffset { get; set; }
    }

}
