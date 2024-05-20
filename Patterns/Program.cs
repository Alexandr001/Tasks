// See https://aka.ms/new-console-template for more information

using Patterns.ChainOfResponsibility;

PipelineBuilder builder = new();
builder.Add(new Test1());
builder.Add(new Test2());
builder.Add(async next =>
{
    Console.WriteLine("start method");
    await next();
    Console.WriteLine("stop method");
});
await builder.Run();