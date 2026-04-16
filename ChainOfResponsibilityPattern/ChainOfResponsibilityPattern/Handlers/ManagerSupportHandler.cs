namespace ChainOfResponsibilityPattern.Handlers;

public class ManagerSupportHandler : BaseSupportHandler
{
    public override string Handle(SupportRequest request)
    {
        return $"Manager handled: {request.Description}";
    }
}
