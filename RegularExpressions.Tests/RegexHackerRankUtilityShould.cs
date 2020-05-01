using RegularExpressionsUtility;
using Xunit;
using Xunit.Abstractions;

namespace RegularExpressions.Tests
{
    public class RegexHackerRankUtilityShould
    {
        private readonly RegexHackerRankUtility _sut;
        private readonly ITestOutputHelper _output;
        public RegexHackerRankUtilityShould(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Creating new RegexHackerRankUtility");
            _sut = new RegexHackerRankUtility();
        }

        [Theory]
        [DetectHtmlLinksData]
        [Trait("Category", "DetectHtmlLinks")]
        public void DetectHtmlLinksWhenStringContainsLinks(string input, string output)
        {
            string actual = _sut.DetectHtmlLinks(input);

            Assert.Equal(output, actual);
        }

        [Fact]
        [Trait("Category", "DetectHtmlLinks")]
        public void ReturnNullWhenStringDoesNotContainsLinks()
        {
            string input = @"<div class=""portal"" role=""navigation"" id='p-navigation'>";

            string output = _sut.DetectHtmlLinks(input);

            Assert.Null(output);
        }
    }
}