using System.Collections.ObjectModel;

namespace Createtest.Models.Questions;

public class SingleAnswerQuestion : Question<AnswerOption>
{
    public ReadOnlyCollection<AnswerOption> Options { get; }

    public SingleAnswerQuestion(Guid guid, IList<AnswerOption> options, AnswerOption correctAnswer) : base(guid, correctAnswer)
    {
        ArgumentNullException.ThrowIfNull(options);

        if (options.Count < 2)
            throw new ArgumentException("The options array must contain at least 2 elements.", nameof(options));

        if (!options.Contains(correctAnswer))
            throw new ArgumentException("The options array does not contain the correct answer.", nameof(options));

        Options = new ReadOnlyCollection<AnswerOption>(options);
    }
}
