using System;
using System.Collections.Generic;

namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public static class LinkHelper
    {
        public static void PrintLink(List<int> links)
        {
            foreach (var link in links)
            {
                var m = Links.LinkDic[link];
                if (m == null)
                    continue;
                Console.WriteLine($"- {m.Text}\n{m.Link}");
            }
        }
        
        public static void PrintResult(List<int> results)
        {
            foreach (var link in results)
            {
                var m = Results.ResultDic[link];
                if (m == null)
                    continue;
                Console.WriteLine($"- {m}");
            }
        }
    }
}