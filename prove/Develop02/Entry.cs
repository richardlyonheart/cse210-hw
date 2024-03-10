public class Entry
{
    public string Prompt { get; set; }
    public string UserInput { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string userinput, string date)
    {
        Prompt = prompt;
        UserInput = userinput;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date}\nPrompt: {Prompt}\nResponse: {UserInput}\n";
    }
}