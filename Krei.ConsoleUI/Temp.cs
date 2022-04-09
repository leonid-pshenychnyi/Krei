using Services.Services;

namespace Krei.ConsoleUI;

public class Temp
{
    private readonly InputService _inputService = new("write \"test\"");
    private readonly StepService _stepService = new();
    
    public void Test()
    {
        while (_inputService.IsAbleToStep(_stepService.CurrentStep))
        {
            
        }
    }
}