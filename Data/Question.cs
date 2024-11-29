namespace BlazorASG.Data
{
    public class Question
    {
        public Guid Id { get; }
        public Question()
        {
            Id = Guid.NewGuid();
        }
        public TypeChat TypeChat { set; get; }
        public string Body { get; set; } = "anas";
        public Answer? Awnser { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsRtl { get; set; } = true;


    }


    public enum TypeSuggtion
    {
        OnlyMessage = 0,
        GenerateMassage = 1
    }

    public enum TypeAnswerAI
    {
        Text=0,
        Genreate=1,
        Suggtion=2,
        Form=3,

    }
    public class AnswerAI
    {
        public TypeAnswerAI TypeAnswerAI { get; set; }
        public object? Answer { set; get; }
    }
    public class Answer
    {
        public string? Body { set; get; }
        public AnswerAI? AnswerAI { set; get; }
        public List<SuggtionAnswer>? SuggtionAnswers { set; get; }
    }

    public class SuggtionAnswer
    {
        public string? Body { set; get; }
        public TypeSuggtion TypeSuggtion { set; get; }

        public  object? Sender { set; get; }
    }
}
