using MediatorPattern.Mediators;

namespace MediatorPattern.Colleagues;

public class User
{
    private readonly IChatMediator _mediator;

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public string Name { get; }

    public void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _mediator.Send(message, this);
    }

    public void Receive(string sender, string message)
    {
        Console.WriteLine($"{Name} received from {sender}: {message}");
    }
}
