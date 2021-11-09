namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public class ScoreHelper
    {
        public static string GetByDepression(int v)
        => v switch
            {
                < 10 =>
                    "根据你对问题1-8的回答，你没有遇到许多抑郁症的症状。" +
                    "然而，如果你对自己的健康或情绪有任何担忧，请拨打NHS 111或安排与你的全科医生交谈。",
                    // "Based on your responses to questions 1-8, you're not experiencing many of
                    // the symptoms seen in depression. However, if you have any concerns about
                    // your health or mood, please call NHS 111 or arrange to speak to your GP",
                < 19 =>
                    "根据你对问题1-8的回答，你正经历着一些抑郁症的症状，但只有有经验的健康专家才能确定。\n" +
                    "你应该预约你的全科医生进行交谈，或拨打 NHS 111。两者都可以帮助你，评估你是否可能从额外的支持或治疗中受益。",
                    // "Based on your responses to questions 1-8, you are experiencing some
                    // symptoms seen in depression but only an experienced health professional can
                    // tell for sure. \nYou should make an appointment to see your GP for a review
                    // or call NHS 111. Both can help you and assess whether you might benefit from
                    // extra support or treatment.",
                _ =>
                    "根据你对问题1-8的回答，你正经历着许多抑郁症的症状，但只有有经验的健康专家才能确定。\n" +
                    "你应该在接下来的几天到一周内预约你的全科医生，或者拨打 NHS 111。他们可以帮助你并提供某种形式的治疗。",
                    // "Based on your responses to questions 1-8, you are experiencing many symptoms
                    // seen in depression but only an experienced health professional can tell for sure. \n
                    // You should make an appointment to see your GP over the next few days to a week or call
                    // NHS 111. They can help you and offer some form of treatment."
            };

        public static string GetByAnxiety(int v)
            => v switch
            {
                0 =>
                    "根据你对问题10-16的回答，你没有出现任何焦虑的症状。" +
                    "焦虑程度可能存在波动，所以如果你有不同的感觉，请进行再一次测试。",
                    // "Based on your responses to questions 10-16, you are not experiencing any
                    // of the symptoms of anxiety. Anxiety levels can fluctuate so come back and
                    // retake the test if you rre feeling differently.",
                < 6 =>
                    "根据你对问题10-16的回答，你正经历着一些焦虑症的症状。不时感到焦虑或担心是非常正常的。" +
                    "然而，如果你开始难以控制你的焦虑，可能是时候采取行动了。请查阅有用的链接以了解更多信息。",
                    // "Based on your responses to questions 10-16, you are experiencing some
                    // symptoms seen in anxiety. Feeling anxious or worried from time to time
                    // is perfectly normal. However, if you begin to have trouble controlling
                    // your anxiety it could be time to take action. See useful links for more
                    // information.",
                < 11 =>
                    "根据你对问题10-16的回答，你正经历着一些焦虑症的症状。" +
                    "偶尔感到焦虑或担心是非常正常的，但如果它开始影响你的日常生活，就该采取行动了。" +
                    "如果你觉得这已经影响到你的生活，可以考虑去看你的全科医生。",
                    // "Based on your responses to questions 10-16, you are experiencing some
                    // symptoms seen in anxiety. Feeling anxious or worried from time to time
                    // is perfectly normal but if it's starting to affect your daily life,
                    // it's time to take action. Consider seeing your GP if you feel this is
                    // affecting your life.",
                _ =>
                    "根据你对问题10-16的回答，你正经历着许多焦虑症的症状。" +
                    "这可能对你的日常生活有很大影响，你也可能出现身体症状。" +
                    "请与你的全科医生预约，讨论你的感觉如何。有一些疗法可以帮助你。",
                   // "Based on your responses to questions 10-16, you are experiencing many
                   // symptoms seen in anxiety. This is probably having a big impact on your
                   // daily life and you may also be experiencing physical symptoms. Make an
                   // appointment with your GP to discuss how you're feeling. There are
                   // talking therapies that can help."
            };
    }
}