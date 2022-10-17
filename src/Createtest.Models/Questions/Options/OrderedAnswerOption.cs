namespace Createtest.Models.Questions.Options;

public class OrderedAnswerOption : AnswerOption
{
    private int _order = 1;

    public int Order
    {
        get => _order;
        init => _order = (value >= 1) ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    public OrderedAnswerOption(Guid guid) : base(guid) { }
}
