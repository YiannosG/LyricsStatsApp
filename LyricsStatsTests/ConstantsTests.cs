using LyricsStats;
using Xunit;

namespace LyricsStatsTests
{
    public class ConstantsTests
    {
        [Fact]
        public void TestArtistQueryFront()
        {
            var result = Constants.ArtistQueryFront;

            Assert.Equal("artist/?query=artist:%22", result);
        }

        [Fact]
        public void TestArtistQueryBack()
        {
            var result = Constants.ArtistQueryBack;

            Assert.Equal("%22&fmt=json", result);
        }

        [Fact]
        public void TestGetReleasesFront()
        {
            var result = Constants.GetReleasesFront;

            Assert.Equal("release-group?artist=", result);
        }

        [Fact]
        public void TestGetReleasesBack()
        {
            var result = Constants.GetReleasesBack;

            Assert.Equal("&type=album|ep&fmt=json", result);
        }

        [Fact]
        public void TestGetRecordingsFront()
        {
            var result = Constants.GetRecordingsFront;

            Assert.Equal("recording/?query=rgid:", result);
        }

        [Fact]
        public void TestGetRecordingsBack()
        {
            var result = Constants.GetRecordingsBack;

            Assert.Equal("&fmt=json", result);
        }
    }
}
