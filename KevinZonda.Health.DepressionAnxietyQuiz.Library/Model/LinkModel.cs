namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public class LinkModel
    {
        public string Text { get; private set; }
        public string Link { get; private set; }

        public static LinkModel Create(string text, string link)
            => new LinkModel()
            {
                Text = text,
                Link = link
            };
    }
}