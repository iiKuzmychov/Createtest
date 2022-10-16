namespace Createtest.Models.Questions;

public abstract class Question<TAnswer> : IQuestion
    where TAnswer : notnull
{
    private string _text = string.Empty;
    private int _points = 1;

    public Guid Guid { get; }
    public string Text
    {
        get => _text;
        init => _text = value ?? throw new ArgumentNullException(nameof(value));
    }
    public Uri? ImageUrl { get; init; }
    public int Points
    {
        get => _points;
        init => _points = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public TAnswer Answer { get; }
    object IQuestion.CorrectAnswer => Answer;

    public Question(Guid guid, TAnswer answer)
    {
        Guid   = guid;
        Answer = answer ?? throw new ArgumentNullException(nameof(answer));
    }
}
