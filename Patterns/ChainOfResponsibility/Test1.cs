namespace Patterns.ChainOfResponsibility;

public class Test1 : IPipelineStep
{
    public StepDelegate Next { get; set; }

    public async Task Handle()
    {
        Console.WriteLine("start тест1");
        await Next();
        Console.WriteLine("stop тест1");
    }
}