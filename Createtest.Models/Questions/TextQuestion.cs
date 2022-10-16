namespace Createtest.Models.Questions;

public class TextQuestion : Question<string>
{
    public TextQuestion(Guid guid, string correctAnswer) : base(guid, correctAnswer)
    {
        if (correctAnswer is null)
            throw new ArgumentNullException(nameof(correctAnswer));

        if (string.IsNullOrWhiteSpace(correctAnswer))
            throw new ArgumentException("The correct answer is empty string.", nameof(correctAnswer));
    }
}
