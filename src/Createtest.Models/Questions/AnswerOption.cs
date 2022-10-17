namespace Createtest.Models.Questions;

public class AnswerOption
{
    private string _text = string.Empty;

    public Guid Guid { get; }
    public string Text
    {
        get => _text;
        init => _text = value ?? throw new ArgumentNullException(nameof(value));
    }
    public Uri? ImageUrl { get; init; }

    public AnswerOption(Guid guid)
    {
        Guid = guid;
    }
}
