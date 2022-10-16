namespace Createtest.Models.Questions;

public class NumericAnswerQuestion : Question<double>
{
    public NumericAnswerQuestion(Guid guid, double correctAnswer) : base(guid, correctAnswer) { }
}
