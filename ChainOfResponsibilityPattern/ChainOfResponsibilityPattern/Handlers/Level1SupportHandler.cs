namespace ChainOfResponsibilityPattern.Handlers;

public class Level1SupportHandler : BaseSupportHandler
{
    public override string Handle(SupportRequest request)
    {
        if (request.Priority <= 1)
        {
            return $"Level 1 handled: {request.Description}";
        }

        return base.Handle(request);
    }
}
