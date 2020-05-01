using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressionsUtility
{
    public class RegexHackerRankUtility
    {
        public string DetectHtmlLinks(string input)
        {
            return string
                .Join("\n", Regex.Matches(input, @"<a\shref=""(.*?)"".*?>([\w\s,\./]*?)(?=</)")
                    .Cast<Match>().Select(match => $"{match.Groups[1].Value.Trim()},{match.Groups[2].Value.Trim()}"));
        }
    }
}