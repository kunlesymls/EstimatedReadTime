using ReadTime.Library;
using System;

namespace ReadTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ICalculateReadTime calculator = new CalculateReadTime();
            string word1 = "    This-is an ;apple   T hud   Today is Thursday    ";
            string word2 = "    This-is an ;apple   T hud   Today is Thursday    ";

            string[] stringArray = { word1, word2 };
            Console.WriteLine(calculator.GetWordCountFromFile(@"C:\Users\JOSEPH AJILEYE.DESKTOP-2LUKB0G\Desktop\test.txt"));
            Console.WriteLine(calculator.GetEstimatedTimeFromFile(@"C:\Users\JOSEPH AJILEYE.DESKTOP-2LUKB0G\Desktop\test.txt"));

            Console.ReadLine();
        }
    }
}
