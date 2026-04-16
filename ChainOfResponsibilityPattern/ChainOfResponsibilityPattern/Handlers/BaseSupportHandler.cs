namespace ChainOfResponsibilityPattern.Handlers;

public abstract class BaseSupportHandler : ISupportHandler
{
    private ISupportHandler? _next;

    public ISupportHandler SetNext(ISupportHandler next)
    {
        _next = next;
        return next;
    }

    public virtual string Handle(SupportRequest request)
    {
        return _next?.Handle(request) ?? $"No handler found for: {request.Description}";
    }
}
