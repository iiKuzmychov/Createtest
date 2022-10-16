namespace Createtest.Models;

public class TestVariant
{
    private string _name = string.Empty;
    private IList<IQuestion> _questions = Array.Empty<IQuestion>();

    public Guid Guid { get; }
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
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
