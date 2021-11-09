using System.Collections.Generic;
using KevinZonda.Health.DepressionAnxietyQuiz.Library.Model;

namespace KevinZonda.Health.DepressionAnxietyQuiz.Library
{
    public class Links
    {
        public static readonly Dictionary<int, LinkModel> LinkDic = new()
        {
            {
                849, LinkModel.Create(
                    "Get help for low mood, depression and sadness",
                    @"https://www.nhs.uk/conditions/stress-anxiety-depression/low-mood-and-depression/"
                )
            },
            {
                861, LinkModel.Create(
                    "10 tips to beat insomnia",
                    @"https://www.nhs.uk/live-well/sleep-and-tiredness/10-tips-to-beat-insomnia/"
                )
            },
            {
                862, LinkModel.Create(
                    "Generalised anxiety disorder",
                    @"https://www.nhs.uk/conditions/generalised-anxiety-disorder/"
                )
            },
            {
                850, LinkModel.Create(
                    "Get help with anxiety, fear and panic",
                    @"https://www.nhs.uk/conditions/stress-anxiety-depression/understanding-panic/"
                )
            },
            {
                851, LinkModel.Create(
                    "Get help with stress",
                    @"https://www.nhs.uk/conditions/stress-anxiety-depression/understanding-stress/"
                )
            },
            {
                852, LinkModel.Create(
                    "5 steps to mental wellbeing",
                    @"https://www.nhs.uk/conditions/stress-anxiety-depression/improve-mental-wellbeing/"
                )
            },
            {
                853, LinkModel.Create(
                    "Mental health apps on the NHS Apps Library",
                    @"https://www.nhs.uk/apps-library/category/mental-health/"
                )
            },
            {
                854, LinkModel.Create(
                    "Healthy weight",
                    @"https://www.nhs.uk/live-well/healthy-weight/"
                )
            },
            {
                855, LinkModel.Create(
                    "Reduced sex drive (loss of libido)",
                    @"https://www.nhs.uk/conditions/loss-of-libido/"
                )
            },
            {
                856, LinkModel.Create(
                    "Relate: relationship support for everyone",
                    @"https://www.relate.org.uk"
                )
            },
            {
                857, LinkModel.Create(
                    "Social care and support guide",
                    @"https://www.nhs.uk/conditions/social-care-and-support-guide/"
                )
            },
            {
                858, LinkModel.Create(
                    "How to cope with money worries",
                    @"https://www.nhs.uk/conditions/stress-anxiety-depression/coping-with-financial-worries/"
                )
            },
            {
                859, LinkModel.Create(
                    "Feeling lonely",
                    @"https://www.nhs.uk/conditions/stress-anxiety-depression/feeling-lonely/"
                )
            },
            {
                860, LinkModel.Create(
                    "Post-traumatic stress disorder (PTSD)",
                    @"https://www.nhs.uk/conditions/post-traumatic-stress-disorder-ptsd/"
                )
            },
            {
                376, LinkModel.Create(
                    "Living Life to the Full: free online courses covering low mood, stress and resiliency",
                    @"http://www.llttf.com/"
                )
            },
            {
                378, LinkModel.Create(
                    "Mind, the mental health charity",
                    @"https://www.mind.org.uk/"
                )
            },
            {
                404, LinkModel.Create(
                    "Anxiety UK",
                    @"https://www.anxietyuk.org.uk/"
                )
            },
            {
                408, LinkModel.Create(
                    "Samaritans",
                    @"https://www.samaritans.org/"
                )
            },
        };
    }
}