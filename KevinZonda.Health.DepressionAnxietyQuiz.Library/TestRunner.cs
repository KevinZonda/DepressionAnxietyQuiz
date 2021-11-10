using System;
using System.Collections.Generic;
using System.Text;
using KevinZonda.Health.DepressionAnxietyQuiz.Library.Data;
using KevinZonda.Health.DepressionAnxietyQuiz.Library.Model;
using ValueType = KevinZonda.Health.DepressionAnxietyQuiz.Library.Model.ValueType;

namespace KevinZonda.Health.DepressionAnxietyQuiz.Library
{
    public class TestRunner
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Score: ").Append(Score).AppendLine().Append("Result: ");
            foreach (var i in Results)
            {
                sb.Append(i).Append(", ");
            }

            sb.AppendLine();
            sb.Append("Link: ");
            foreach (var i in Links)
            {
                sb.Append(i).Append(", ");
            }

            return sb.ToString();
        }

        public int Score { get; set; } = 0;
        public List<int> Results { get; set; } = new();
        public List<int> Links { get; set; } = new();

        private List<QuizModel> quizModel;

        public TestRunner(List<QuizModel> qzmd)
        {
            quizModel = qzmd;
        }

        public void Run()
        {
            foreach (var v in quizModel)
            {
                Run(v);
            }
        }

        private void ChoiceTo(int choice, QuizModel qm)
        {
            var v = qm.Values;
            
            if (choice != 0 && qm.NotZeroLink > 0)
            {
                Links.Add(qm.NotZeroLink);
            }

            var vm = v[choice].Values;

            if (vm == null)
                return;

            foreach (var i in vm)
            {
                switch (i.Type)
                {
                    case ValueType.Link:
                        Links.Add(i.Value);
                        break;
                    case ValueType.Result:
                        Results.Add(i.Value);
                        break;
                    case ValueType.Score:
                        Score += i.Value;
                        break;
                }
            }
        }

        public void Run(QuizModel qm)
        {
            int info = qm.InfoLink;

            if (info > 0)
            {
                var i = Info.Dic[info];
                Console.WriteLine($"[{i.Title}] {i.Name}");
                Console.WriteLine(i.Body);
            }
            string isSgl = qm.IsSingle ? "单选题" : "多选题";
            Console.WriteLine($"[{isSgl}] {qm.Text}");

            var sb = new StringBuilder();


            if (qm.InfoLink > 0)
            {
                sb.Append("I").Append(qm.InfoLink).Append(", ");
            }


            var v = qm.Values;
            int counter = 0;
            foreach (var i in v)
            {
                Console.WriteLine($"[{counter}] {i.Text}");
                ++counter;
            }

            if (qm.IsSingle)
            {
                int choice = int.Parse(Console.ReadLine());
                ChoiceTo(choice, qm);
            }
            else
            {
                var s = Console.ReadLine();
                foreach (var c in s)
                {
                    ChoiceTo(int.Parse(c.ToString()), qm);
                }
            }
        }
    }
}