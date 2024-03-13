public static class RandomPrompt
{
    private static List<string> prompts = new List<string>
    {
       
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "what was the coolest thing you saw today?",
        "did you see any cool birds today?",
        "Why didnt you dress up like a cowboy today?",
        "how many fingers am I holding up?"
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}