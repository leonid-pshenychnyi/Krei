using Krei.Data;

namespace Services.Services;

public class KeywordsService
{
    private readonly Keywords Keywords = new Keywords();
    public Action<List<string>, int, Action<int>> GetKeyword(string key)
    {
        return (Keywords.keywords.ContainsKey(key) ? Keywords.keywords[key] : null) ?? throw new InvalidOperationException();
    }
}