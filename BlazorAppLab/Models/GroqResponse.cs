namespace BlazorAppLab.Models
{
    public class GroqResponse
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public int Created { get; set; }
        public string Model { get; set; }
        public List<Choice> Choices { get; set; }
        public Usage Usage { get; set; }
        public object UsageBreakdown { get; set; }
        public string SystemFingerprint { get; set; }
        public XGroq XGroq { get; set; }
        public string ServiceTier { get; set; }
    }

    public class Choice
    {
        public int Index { get; set; }
        public Message Message { get; set; }
    }

    public class Message
    {
        public string Role { get; set; }
        public string Content { get; set; }
    }

    public class Usage
    {
        public int PromptTokens { get; set; }
        public int CompletionTokens { get; set; }
        public int TotalTokens { get; set; }
    }

    public class XGroq
    {
        public string Id { get; set; }
    }
}

