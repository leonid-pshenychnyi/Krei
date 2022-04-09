namespace Services.Services;

public class InputService
{
    public InputService(string inputString)
    {
        _input = inputString;
    }

    private readonly string _input;

    public List<string> GetTokens()
    {
        return _input.Split(' ').ToList();
    }

    public bool IsAbleToStep(int steps)
    {
        return steps < GetTokens().Count;
    }
}