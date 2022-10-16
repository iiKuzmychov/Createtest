namespace Createtest.Models.Questions;

public class TextAnswerQuestion : Question<string>
{
    public TextAnswerQuestion(Guid guid, string correctAnswer) : base(guid, correctAnswer)
    {
        if (correctAnswer is null)
            throw new ArgumentNullException(nameof(correctAnswer));

        if (string.IsNullOrWhiteSpace(correctAnswer))
            throw new ArgumentException("The correct answer is empty string.", nameof(correctAnswer));
    }
}
