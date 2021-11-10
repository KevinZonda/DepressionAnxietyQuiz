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

            TestRunner tr = new(Quiz.DepressionQuiz);
            tr.Run();
            TestRunner atr = new(Quiz.AnxiousQuiz);
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

        public static void PrintQuizModel(QuizModel qm)
        {
            var isSgl = qm.IsSingle ? "S" : "M";
            Console.WriteLine($"[{isSgl}] {qm.Text}");

            var sb = new StringBuilder();


            if (qm.InfoLink > 0)
            {
                sb.Append('I').Append(qm.InfoLink).Append(", ");
            }

            var v = qm.Values;
            foreach (var i in v)
            {
                Console.Write($"  - {i.Text}: ");
                if (i.Values != null)
                    foreach (var k in i.Values)
                    {
                        if (k.Type == ValueType.Score)
                        {
                            Console.Write(k.Value + ", ");
                            if (k.Value > 0 && qm.NotZeroLink > 0)
                            {
                                Console.Write("L" + qm.NotZeroLink + ", ");
                            }

                            continue;
                        }

                        Console.Write(k.Type.ToString().Substring(0, 1).ToUpper());
                        Console.Write(k.Value);
                        Console.Write(", ");
                    }


                Console.WriteLine();
            }
        }
    }
}