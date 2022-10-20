using Createtest.Models.Questions.Options;
using System.Collections.ObjectModel;

namespace Createtest.Models.Questions;

public class SequenceQuestion : Question<ReadOnlyCollection<OrderedAnswerOption>>
{
    public SequenceQuestion(Guid guid, IList<OrderedAnswerOption> correctAnswer)
        : base(guid, new(correctAnswer))
    {
        ArgumentNullException.ThrowIfNull(correctAnswer);

        if (correctAnswer.Count < 2)
            throw new ArgumentException("The correct answer must contain at least 2 options.", nameof(correctAnswer));

        if (correctAnswer.Count != correctAnswer.DistinctBy(answer => answer.Order).Count())
            throw new ArgumentException("The correct answer contains 2 options of the same order.", nameof(correctAnswer));

        // подумать о Distinct
    }
}
