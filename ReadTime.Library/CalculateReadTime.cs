using System.Collections.Generic;
using System.Linq;

namespace ReadTime.Library
{
    public class CalculateReadTime : ICalculateReadTime
    {
        private List<char> delimeters = new List<char> { ' ', ',', '.', '-', '_', ';', ':' };

        /// <summary>
        /// This constructor accepts custom delimiters and averageTime to read
        /// with a default delimiters and 200 average words per minute
        /// </summary>
        /// <param name="customDelimiter">char[]</param>
        /// <param name="averageTime">int</param>
        public CalculateReadTime(char[] customDelimiter = null, int averageTime = 200)
        {
            delimeters.AddRange(customDelimiter);
        }
        public double Calculate(string words)
        {
            return GetWordCount(words) / 200;
        }

        public double Calculate(string[] words)
        {
            return GetWordCount(words) / 200;
        }
        public int GetWordCount(string words)
        {
            string[] splitWords = words.Trim().Split(delimeters.ToArray());
            return splitWords.Count(x => x != "");
        }

        public int GetWordCount(string[] words)
        {
            return words.Sum(s => GetWordCount(s));
        }
    }
}
