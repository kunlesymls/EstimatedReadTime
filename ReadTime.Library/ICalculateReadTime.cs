namespace ReadTime.Library
{
    public interface ICalculateReadTime
    {
        /// <summary>
        /// This method calculate the words and return the estimated time to read
        /// </summary>
        /// <param name="words">string</param>
        /// <returns>double</returns>
        string GetEstimatedTime(string words);

        /// <summary>
        /// This method calculate the words and return the estimated time to read
        /// </summary>
        /// <param name="words">string[]</param>
        /// <returns>double</returns>
        string GetEstimatedTime(string[] words);

        /// <summary>
        /// This method reads file content and calculate the average time to read
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        string GetEstimatedTimeFromFile(string filePath);

        /// <summary>
        /// This method returns the number of words in a string 
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        int GetWordCount(string words);

        /// <summary>
        /// This method returns the number of words in a file
        /// </summary>
        /// <param name="words"></param>
        /// <returns>int</returns>
        int GetWordCountFromFile(string filePath);


        /// <summary>
        /// This method returns the total words is a string array
        /// </summary>
        /// <param name="words">string[]</param>
        /// <returns>int</returns>
        int GetWordCount(string[] words);
    }
}
