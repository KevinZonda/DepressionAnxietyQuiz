using System.Collections.Generic;

namespace KevinZonda.Health.DepressionAnxietyQuiz.Library
{
    public static class Infos
    {
        public static readonly Dictionary<int, InfoItem> InfoDic = new()
        {
            {
                188, new InfoItem
                {
                    Title = "关于这些问题",
                    Body = "以下九个问题取自医生使用的一种措施，称为个人健康问卷或 PHQ-9。" +
                           "这些问题是用来评估和监测抑郁症的严重程度。PHQ-9 是由 " +
                           "Robert L Spitzer、Janet BW Williams、Kurt Kroenke " +
                           "及其同事开发的，由辉瑞公司提供教育资助。",
                    Name = "关于抑郁症的问题"
                }
            },
            {
                164, new InfoItem
                {
                    Title = "什么是焦虑攻击？",
                    Body = "当你的身体出现强烈的心理（精神）和身体症状时，就会发生焦虑或惊恐发作。\n" +
                           "你可能感到一种压倒性的恐惧、忧虑和焦虑。除了这些感觉外，你还可能出现身体症状，如：\n" +
                           "- 恶心\n" +
                           "- 出汗\n" +
                           "- 颤抖\n" +
                           "- 感觉你的心脏在不规则地跳动（心悸）\n" +
                           "你还可能感觉你需要停止正在做的事情，赶紧离开。你可能开始回避以前发生过惊恐发作的情况、人或地方，这有时会导致你回避大多数人可以应付的事情。\n" +
                           "焦虑可以通过许多方式表现出来，如感觉坐立不安、经常处于紧张状态、易怒、难以集中注意力或回避朋友。",
                    Name = "什么是焦虑攻击？",
                }
            },
            {
                161, new InfoItem
                {
                    Title = "关于这些问题",
                    Body = "以下七个问题是基于医生使用的一种测量方法，被称为 “广泛性焦虑症测试表 7”或GAD-7。" +
                           "这些问题用于评估和监测一个人的焦虑的严重程度。" +
                           "GAD-7 是由 Robert L Spitzer、Janet BW Williams、Kurt Kroenke 及其同事开发的，由辉瑞公司提供教育资助。",
                    Name = "关于焦虑症的问题"
                }
            }
        };
    }

    public class InfoItem
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
    }
}