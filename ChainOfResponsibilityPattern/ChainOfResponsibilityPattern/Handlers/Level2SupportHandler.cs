namespace ChainOfResponsibilityPattern.Handlers;

public class Level2SupportHandler : BaseSupportHandler
{
    public override string Handle(SupportRequest request)
    {
        if (request.Priority == 2)
        {
            return $"Level 2 handled: {request.Description}";
        }

        return base.Handle(request);
    }
}
