namespace InterpreterPattern.Expressions;

public class NumberExpression : IExpression
{
    private readonly int _value;

    public NumberExpression(int value)
    {
        _value = value;
    }

    public int Interpret() => _value;
}
