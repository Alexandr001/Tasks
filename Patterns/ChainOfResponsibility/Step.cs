namespace Patterns.ChainOfResponsibility;

internal class Step : IPipelineStep
{
    private readonly Func<StepDelegate, Task> _method;

    public StepDelegate Next { get; set; } = null!;

    public Step(Func<StepDelegate, Task> method)
    {
        _method = method;
    }

    public Task Handle()
    {
        return _method(Next);
    }
}