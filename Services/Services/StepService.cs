namespace Services.Services;

public class StepService
{
    public int CurrentStep;

    public void AddSteps(int steps)
    {
        if (CurrentStep + steps < 0)
            throw new Exception("Steps count less then zero");
    }
}