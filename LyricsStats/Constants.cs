using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace LyricsStats
{
    public static class Constants
    {
        /// <summary>
        /// The two parts of string that go on either side of the artist. the %22 code is necessary to get exact results and not the proximations
        /// </summary>
        public static string ArtistQueryFront => "artist/?query=artist:%22";
        public static string ArtistQueryBack => "%22&fmt=json";

        public static string GetReleasesFront => "release-group?artist=";
        public static string GetReleasesBack => "&type=album|ep&fmt=json";

        public static string GetRecordingsFront => "recording/?query=rgid:";
        public static string GetRecordingsBack => "&fmt=json";
    }
}
