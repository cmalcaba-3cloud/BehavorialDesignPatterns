namespace ChainOfResponsibilityPattern.Handlers;

public interface ISupportHandler
{
    ISupportHandler SetNext(ISupportHandler next);
    string Handle(SupportRequest request);
}
