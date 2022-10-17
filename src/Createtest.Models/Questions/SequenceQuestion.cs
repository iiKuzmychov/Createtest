using Createtest.Models.Questions.Options;
using System.Collections.ObjectModel;

namespace Createtest.Models.Questions;

public class SequenceQuestion : Question<ReadOnlyCollection<AnswerOption>>
{
    public SequenceQuestion(Guid guid, IList<AnswerOption> correctAnswer)
        : base(guid, new(correctAnswer))
    {
        ArgumentNullException.ThrowIfNull(correctAnswer);

        if (correctAnswer.Count < 2)
            throw new ArgumentException("The correct answer list must contain at least 2 elements.", nameof(correctAnswer));
    }
}
