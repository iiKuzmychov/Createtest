using Createtest.Models.Questions;

namespace Createtest.Models;

public class TestVariant
{
    private IList<IQuestion> _questions = Array.Empty<IQuestion>();

    public Guid Guid { get; }
    public IList<IQuestion> Questions
    {
        get => _questions;
        set => _questions = value ?? throw new ArgumentNullException(nameof(value));
    }

    public TestVariant(Guid guid)
    {
        Guid = guid;
    }
}
