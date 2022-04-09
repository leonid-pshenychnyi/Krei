StaticData.Keywords.Add("write", () =>
{
    var t = StaticData.Tokens[StaticData.Step + 1];
    Console.WriteLine(t);
    StaticData.Step++;
});


while (StaticData.Step < StaticData.Tokens.Count)
{
    StaticData.Keywords[StaticData.Tokens[StaticData.Step]]();
    StaticData.Step++;
}

static class StaticData
{
    public static int Step;
    public static Dictionary<string, Action> Keywords;
    public static List<string> Tokens;

    static StaticData()
    {
        Tokens = "write test".Split(' ').ToList();
        Keywords = new Dictionary<string, Action>();
    }
}