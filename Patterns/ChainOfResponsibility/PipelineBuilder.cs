namespace Patterns.ChainOfResponsibility;

public delegate Task StepDelegate();

public class PipelineBuilder
{
    private readonly List<IPipelineStep> _pipelines = new();

    private int _index;

    public void Add(IPipelineStep pipelineStep)
    {
        AddStep(pipelineStep);
    }

    public void Add(Func<StepDelegate, Task> method)
    {
        IPipelineStep step = new Step(method);
        AddStep(step);
    }

    public async Task Run()
    {
        if (_pipelines.Count == 0)
        {
            return;
        }
        _pipelines.Last().Next = () => Task.CompletedTask;
        await _pipelines[0].Handle();
    }

    private void AddStep(IPipelineStep step)
    {
        if (_index > 0)
        {
            _pipelines.Add(step);
            _pipelines[_index - 1].Next = step.Handle;
        }
        else
        {
            _pipelines.Add(step);
        }
        _index++;
    }
}