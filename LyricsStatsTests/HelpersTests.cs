using LyricsStats;
using Xunit;

namespace LyricsStatsTests
{
    public class HelpersTests
    {
        [Fact]
        public void TestRemoveDiacritics()
        {
            var result = Helpers.RemoveDiacritics("crème brûlée");

            Assert.Equal("creme brulee", result);
        }

        [Fact]
        public void TestSlugify()
        {
            var result = Helpers.Slugify("@Beach    Boys").ToLower();

            Assert.Equal("beach-boys", result);
        }

        [Fact]
        public void TestWordCount()
        {
            var result = Helpers.GetWordCount("I don't get the lyrics");

            Assert.Equal(5, result);
        }
    }
}
