namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public class LinkModel
    {
        public string Text { get; private init; }
        public string Link { get; private init; }

        public static LinkModel Create(string text, string link)
            => new()
            {
                Text = text,
                Link = link
            };
    }
}