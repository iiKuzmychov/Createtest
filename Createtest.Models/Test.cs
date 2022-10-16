namespace Createtest.Models;

public class Test
{
    private string _name = string.Empty;
    private IList<TestVariant> _variants = Array.Empty<TestVariant>();

    public Guid Guid { get; }
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
    public IList<TestVariant> Variants
    {
        get => _variants;
        set => _variants = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Test(Guid guid)
    {
        Guid = guid;
    }
}