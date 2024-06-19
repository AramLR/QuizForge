using System;
using System.Reflection;

namespace QuizForge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {

                var versionString = "1.0.0";

                Console.WriteLine($"quizforge v{versionString}");

                Console.WriteLine("\nUsage: quizforge <csv> [options]");

                Console.WriteLine("\nParameters:");

                Console.WriteLine("  <csv>                  Path to the exported Anki cards CSV file");

                Console.WriteLine("\nOptions:");

                Console.WriteLine("  --num-questions N      Number of questions to include in the mock exam (default: 10).");
                Console.WriteLine("  --question-type T      Type of questions: 'open' or 'closed' (default: 'closed').");
                Console.WriteLine("  --options OPTS         Possible options for multiple choice questions (default: 'A B C D')");
                Console.WriteLine("  --output FILE          Output PDF file name (default: 'mock_exam.pdf'");

                Console.WriteLine("\nExample:");
                Console.WriteLine("  quizforge cards.csv --num-questions 20 --question-type closed --options A B C");
            }
        }
    }
}
