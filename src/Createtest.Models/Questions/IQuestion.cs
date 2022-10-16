namespace Createtest.Models.Questions;

public interface IQuestion
{
    public Guid Guid { get; }
    public string Text { get; }
    public Uri? ImageUrl { get; }
    public int Points { get; }
    public object CorrectAnswer { get; }
}
