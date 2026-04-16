using InterpreterPattern.Expressions;

Console.WriteLine("== Interpreter Pattern: Math Expression ==\n");

IExpression expression = new AddExpression(
    new NumberExpression(10),
    new SubtractExpression(new NumberExpression(8), new NumberExpression(3)));

Console.WriteLine($"Result: {expression.Interpret()}");
