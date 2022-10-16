using System.Collections.ObjectModel;

namespace Createtest.Models.Questions;

public class MultipleAnswersQuestion : Question<ReadOnlyCollection<AnswerOption>>
{
    public ReadOnlyCollection<AnswerOption> Options { get; }

    public MultipleAnswersQuestion(Guid guid, IList<AnswerOption> options, IList<AnswerOption> correctAnswer)
        : base(guid, new ReadOnlyCollection<AnswerOption>(correctAnswer))
    {
        ArgumentNullException.ThrowIfNull(options);

        if (options.Count < 2)
            throw new ArgumentException("The options array must contain at least 2 elements.", nameof(options));

        if (options.Except(correctAnswer).Any())
            throw new ArgumentException("The options array does not contain the correct answer.", nameof(options));

        Options = new ReadOnlyCollection<AnswerOption>(options);
    }
}
