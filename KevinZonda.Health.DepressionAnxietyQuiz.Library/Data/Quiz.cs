using System.Collections.Generic;
using KevinZonda.Health.DepressionAnxietyQuiz.Library.Model;

namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Data
{
    public static class Quiz
    {
        private static readonly List<ValueModel> DefaultValues = new List<ValueModel>()
        {
            new ValueModel
            {
                Text = "完全没有",
                Values = new[]
                {
                    ValueItem.CreateScoreItem(0)
                }
            },
            new ValueModel
            {
                Text = "有几天",
                Values = new[]
                {
                    ValueItem.CreateScoreItem(1)
                }
            },
            new ValueModel
            {
                Text = "超过半数的天数",
                Values = new[]
                {
                    ValueItem.CreateScoreItem(2)
                }
            },
            new ValueModel
            {
                Text = "几乎每一天",
                Values = new[]
                {
                    ValueItem.CreateScoreItem(3)
                }
            },
        };

        public static readonly List<QuizModel> DepressionQuiz = new List<QuizModel>()
        {
            new QuizModel
            {
                InfoLink = 188,
                Text = "你有多少次被沮丧、抑郁或无望的感觉所困扰？",
                NotZeroLink = 849,
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次对做事情没有兴趣或乐趣？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "您是否经常因入睡困难或睡眠不足或睡太多而烦恼？",
                NotZeroLink = 861,
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次因为感到疲惫或精力不足而感到困扰？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多长时间被食欲不佳或暴饮暴食困扰过？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次因为觉得自己不好，或觉得自己是个失败者，或让自己或家人失望而感到困扰？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多长时间被难以集中注意力的事情所困扰过，比如读报纸或看电视？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "您是否经常因为移动或说话的速度太慢以至于其他人可能会注意到，或者相反 - 因为烦躁或不安，以至于您比平时走动得更多？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你是否有过焦虑发作（突然感到恐惧或惊慌）？",
                InfoLink = 164,
                Values = new List<ValueModel>
                {
                    new ValueModel
                    {
                        Text = "是",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(667),
                            ValueItem.CreateLinkItem(862)
                        }
                    },
                    new ValueModel
                    {
                        Text = "否",
                    },
                }
            },
        };


        public static readonly List<QuizModel> AnxiousQuiz = new List<QuizModel>
        {
            new QuizModel
            {
                Text = "你有多少次因为感到紧张、焦虑或提心吊胆而受到困扰？",
                InfoLink = 161,
                Values = DefaultValues
            },
            new QuizModel
            {
                NotZeroLink = 850,
                Text = "你有多少次因为无法停止或控制忧虑而感到困扰？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次因为对不同的事情担心太多而感到困扰？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次因为难以放松而受到困扰？",
                NotZeroLink = 851,
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次因为坐立不安，难以静坐而感到困扰？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "您是否经常因容易生气或易怒而烦恼？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你有多少次因为害怕可能会发生可怕的事情而感到困扰？",
                Values = DefaultValues
            },
            new QuizModel
            {
                Text = "你是否曾因担心以下问题而感到困扰？",
                IsSingle = false,
                Values = new List<ValueModel>
                {
                    new ValueModel
                    {
                        Text = "你的健康",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(648),
                        }
                    },
                    new ValueModel
                    {
                        Text = "你的体重或外貌",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(651),
                            ValueItem.CreateLinkItem(854),
                        }
                    },
                    new ValueModel
                    {
                        Text = "性生活中很少或没有性欲或快感",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(652),
                            ValueItem.CreateLinkItem(855),
                        }
                    },
                    new ValueModel
                    {
                        Text = "与你的伴侣存在困难",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(653),
                            ValueItem.CreateLinkItem(856),
                        }
                    },
                    new ValueModel
                    {
                        Text = "照顾家人的压力",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(654),
                            ValueItem.CreateLinkItem(857),
                        }
                    },
                    new ValueModel
                    {
                        Text = "工作、学校或家庭以外的压力",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(655),
                        }
                    },
                    new ValueModel
                    {
                        Text = "由经济问题或忧虑",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(656),
                            ValueItem.CreateLinkItem(858),
                        }
                    },
                    new ValueModel
                    {
                        Text = "孤独，无人问津",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(657),
                            ValueItem.CreateLinkItem(859),
                        }
                    },
                    new ValueModel
                    {
                        Text = "最近发生不好的事情",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(658),
                            ValueItem.CreateLinkItem(860),
                        }
                    },
                    new ValueModel
                    {
                        Text = "以上都不是",
                    },
                },
            },
            new QuizModel
            {
                Text = "如果此问卷突出显示了任何问题，这些问题对您的工作、在家照顾事物或与他人相处造成了多大的困难？",
                IsSingle = false,
                Values = new List<ValueModel>
                {
                    new ValueModel
                    {
                        Text = "没有任何困难",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(1374),
                            ValueItem.CreateResultItem(1375),
                        }
                    },
                    new ValueModel
                    {
                        Text = "有一些困难",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(689),
                            ValueItem.CreateResultItem(1374),
                            ValueItem.CreateResultItem(1375),
                        }
                    },
                    new ValueModel
                    {
                        Text = "非常困难",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(691),
                            ValueItem.CreateResultItem(1374),
                            ValueItem.CreateResultItem(1375),
                        }
                    },
                    new ValueModel
                    {
                        Text = "极度困难",
                        Values = new[]
                        {
                            ValueItem.CreateResultItem(691),
                            ValueItem.CreateResultItem(1374),
                            ValueItem.CreateResultItem(1375),
                        }
                    },
                }
            }
        };
    }
}