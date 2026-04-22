using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public abstract class DamageHandler
{
    private DamageHandler? _next;

    /// <summary>
    /// Sets the next handler in the chain and returns it to allow fluent chaining.
    /// </summary>
    public DamageHandler SetNext(DamageHandler next)
    {
        _next = next;
        return next;
    }

    /// <summary>
    /// Processes the incoming damage request. Subclasses override this to intercept
    /// the request; call base.Handle() to pass it along the chain.
    /// </summary>
    public virtual void Handle(DamageRequest request, Character character)
    {
        _next?.Handle(request, character);
    }
}
