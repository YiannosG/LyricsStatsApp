using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsStats
{
    public static class Helpers
    {
        /// <summary>
        /// Removes irregular characters like French accent characters from a string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>String with removed accents</returns>
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        /// Removes non-valid characters, compresses spaces and replaces them with dashes
        /// </summary>
        /// <param name="phrase">Input string</param>
        /// <returns>Output string</returns>
        public static string Slugify(this string phrase)
        {
            string str = RemoveDiacritics(phrase).ToLower();
            str = System.Text.RegularExpressions.Regex.Replace(str, @"[^a-z0-9\s-]", "");           // Remove all non valid chars          
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ").Trim();            // convert multiple spaces into one space  
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s", "-");                    //Replace spaces by dashes
            return str;
        }

        /// <summary>
        /// Gets the word count from a string
        /// </summary>
        /// <param name="text">Input string</param>
        /// <returns>An integer denoting the word count</returns>
        public static int GetWordCount(string text)
        {
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            return wordCount;
        }
    }
}
