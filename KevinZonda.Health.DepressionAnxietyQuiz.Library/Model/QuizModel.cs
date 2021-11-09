using System.Collections.Generic;

namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public class QuizModel
    {
        public string Text { get; set; }
        public bool IsSingle { get; set; } = true;
        public int InfoLink { get; set; } = -1;
        public int NotZeroLink { get; set; } = -1;
        public List<ValueModel> Values { get; set; }
    }
}