using System;
using System.Text;
using KevinZonda.Health.DepressionAnxietyQuiz.Library;
using KevinZonda.Health.DepressionAnxietyQuiz.Library.Data;
using KevinZonda.Health.DepressionAnxietyQuiz.Library.Model;
using ValueType = KevinZonda.Health.DepressionAnxietyQuiz.Library.Model.ValueType;

namespace KevinZonda.Health.DepressionAnxietyQuiz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(About.Title);
            Console.WriteLine(About.Description);
            Console.WriteLine("输入 y 以开始");
            if (Console.ReadLine().ToLower() != "y")
                return;
            Console.Clear();

            TestRunner tr = new TestRunner(Quiz.DepressionQuiz);
            tr.Run();
            TestRunner atr = new TestRunner(Quiz.AnxiousQuiz);
            atr.Run();
            Console.WriteLine(tr);


            Helper.GetResultByDepressionScore(tr.Score);
            Helper.PrintLink(tr.Links);
            Helper.PrintResult(tr.Results);

            Console.WriteLine();

            Console.WriteLine(atr);
            Helper.GetResultByAnxietyScore(atr.Score);
            Helper.PrintLink(atr.Links);
            Helper.PrintResult(atr.Results);
            Console.WriteLine(About.End);
        }
    }
}