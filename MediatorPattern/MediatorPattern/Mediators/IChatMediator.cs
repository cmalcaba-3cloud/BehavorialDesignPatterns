using MediatorPattern.Colleagues;

namespace MediatorPattern.Mediators;

public interface IChatMediator
{
    void Register(User user);
    void Send(string message, User sender);
}
