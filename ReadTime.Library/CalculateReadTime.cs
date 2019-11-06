using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadTime.Library
{
    public class CalculateReadTime : ICalculateReadTime, IReadFile
    {
        private List<char> delimeters = new List<char> { ' ', ',', '.', '-', '_', ';', ':' };
        private int AverageTimeToRead;
        /// <summary>
        /// This constructor accepts custom delimiters and averageTime to read
        /// with a default delimiters and 200 average words per minute
        /// </summary>
        /// <param name="customDelimiter">char[]</param>
        /// <param name="averageTime">int</param>
        public CalculateReadTime(char[] customDelimiter = null, int averageTime = 200)
        {
            if (customDelimiter != null) // Checking if customDelimiter is not
            {
                delimeters.AddRange(customDelimiter); // add custom delimiter to the delimiter list.
            }
            AverageTimeToRead = averageTime;
        }


        public string GetEstimatedTime(string words)
        {
            // Calling the GetWordCount() method to return the word count of a string.
            // and divide the wordCount by avaerageTimeToRead
            double result = Math.Round((double)GetWordCount(words) / (double)AverageTimeToRead);

            return DisplayReadTime(result);
        }

        public string GetEstimatedTime(string[] words)
        {
            // Calling the GetWordCount() method to return the word count of a string.
            // and divide the wordCount by avaerageTimeToRead
            double result = Math.Round((double)GetWordCount(words) / (double)AverageTimeToRead);

            return DisplayReadTime(result);
        }

        private static string DisplayReadTime(double result)
        {
            return $"Approximately {result} minutes";
        }

        public int GetWordCount(string words)
        {
            // Replace formating string from the words
            words = words.Replace(".", "");
            words = words.Replace(@"\n", "");
            words = words.Replace(@"\r", "");

            // Split words based on the list of delimiters
            string[] splitWords = words.Trim().Split(delimeters.ToArray());

            // return the split-words that are not empty spaces and dots
            return splitWords.Count(x => x != "" && x != ".");
        }

        public int GetWordCount(string[] words)
        {
            // Linq query to sum the iteration over the string array and get the word count 
            return words.Sum(s => GetWordCount(s));
        }

        public int GetWordCountFromFile(string filePath)
        {
            // Calling GetWordCount on ProcessFilePath to get the string from the filePath.
            return GetWordCount(ProcessFilePath(filePath));
        }

        public string GetEstimatedTimeFromFile(string filePath)
        {
            string contents = ProcessFilePath(filePath);
            return GetEstimatedTime(contents);
        }

        public string ProcessFilePath(string path)
        {
            if (path.ToLower().EndsWith(".txt"))
            {
                return ReadTxtFile(path);
            }
            else if (path.ToLower().EndsWith(".pdf"))
            {
                return ReadPdfFile(path);
            }
            else
            {
                return "File Type not supported";
            }
        }

        public string ReadPdfFile(string path)
        {
            // TODO
            return "";
        }

        public string ReadTxtFile(string path)
        {
            return File.ReadAllText(path);
        }

    }
}
