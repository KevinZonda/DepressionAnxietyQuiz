namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public class LinkModel
    {
        public string Text { get; set; }
        public string Link { get; set; }

        public static LinkModel Create(string text, string link)
            => new()
            {
                Text = text,
                Link = link
            };
    }
}