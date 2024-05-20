namespace Patterns.ChainOfResponsibility;

public class Test2 : IPipelineStep
{
    public StepDelegate Next { get; set; }

    public async Task Handle()
    {
        Console.WriteLine("start тест2");
        await Next();
        Console.WriteLine("stop тест2");
    }
}