using System.ComponentModel;

namespace TheBlog.Enums
{
    public enum ModerationType
    {
        [Description("Political")]
        Political,
        [Description("Language")]
        Language,
        [Description("Drugs")]
        Drugs,
        [Description("Threatening")]
        Threatening,
        [Description("Sexual")]
        Sexual,
        [Description("HateSpeech")]
        HateSpeech,
        [Description("Shaming")]
        Shaming,
    }
}
