using MediatorPattern.Colleagues;

namespace MediatorPattern.Mediators;

public class ChatRoomMediator : IChatMediator
{
    private readonly List<User> _users = new();

    public void Register(User user) => _users.Add(user);

    public void Send(string message, User sender)
    {
        foreach (var user in _users.Where(user => user != sender))
        {
            user.Receive(sender.Name, message);
        }
    }
}
