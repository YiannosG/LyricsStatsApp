namespace LyricsStats.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class RecordingModel
    {
        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("recordings")]
        public Recording[] Recordings { get; set; }
    }

    public class Recording
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("video")]
        public object Video { get; set; }

        //[JsonProperty("artist-credit")]
        //public ArtistCredit[] ArtistCredit { get; set; }

        [JsonProperty("releases")]
        public Release[] Releases { get; set; }

        
    }

    public class ArtistCredit
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("artist")]
        public Artist Artist { get; set; }
    }   

    public class Release
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("release-group")]
        public ReleaseGroup ReleaseGroup { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }       

        [JsonProperty("release-events", NullValueHandling = NullValueHandling.Ignore)]
        public ReleaseEvent[] ReleaseEvents { get; set; }

        [JsonProperty("track-count")]
        public long TrackCount { get; set; }

        [JsonProperty("media")]
        public Media[] Media { get; set; }

        [JsonProperty("disambiguation", NullValueHandling = NullValueHandling.Ignore)]
        public string Disambiguation { get; set; }

        //[JsonProperty("artist-credit", NullValueHandling = NullValueHandling.Ignore)]
        //public ArtistCredit[] ArtistCredit { get; set; }
    }

    public class Media
    {
        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("track")]
        public Track[] Track { get; set; }

        [JsonProperty("track-count")]
        public long TrackCount { get; set; }

        [JsonProperty("track-offset")]
        public long TrackOffset { get; set; }
    }

    public class Track
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }
    }

    public class ReleaseEvent
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("area")]
        public Artist Area { get; set; }
    } 

}
