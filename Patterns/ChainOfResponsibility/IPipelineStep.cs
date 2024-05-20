namespace Patterns.ChainOfResponsibility;

public interface IPipelineStep
{
    StepDelegate Next { get; set; }
    Task Handle();
}