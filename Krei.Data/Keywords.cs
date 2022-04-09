namespace Krei.Data;

public class Keywords
{
    public Dictionary<string, Action<List<string>, int, Action<int>>> keywords = new()
    {
        {
            "write",
            (tokens, step, move) =>
            {
                var outputString = string.Empty;

                if (tokens[step + 1].Contains('\"'))
                {
                    for (var index = step + 1; index < tokens.Count; index++)
                    {
                        if (tokens[index].LastOrDefault() != '\"') continue;
                        outputString = string.Join(' ', tokens.Skip(step).Take(tokens.Count - index - step));
                        move(index);
                        break;
                    }

                    Console.WriteLine(outputString);
                }
                else
                {
                    // Recursion
                }
            }
        }
    };
}