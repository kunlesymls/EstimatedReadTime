using ReadTime.Library;
using System;

namespace ReadTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] del = { 'T' };

            ICalculateReadTime calculator = new CalculateReadTime(del);
            string word1 = "    This-is an ;apple   T hud   Today is Thursday    ";
            string word2 = "    This-is an ;apple   T hud   Today is Thursday    ";

            string[] stringArray = { word1, word2 };
            Console.WriteLine(calculator.GetWordCount(stringArray));
            Console.WriteLine(calculator.Calculate(word1));

            Console.ReadLine();
        }
    }
}
