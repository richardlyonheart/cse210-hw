using System.Globalization;
using System.IO;

public class RandomPrompt
{
    public string _prompt01 ="What was the best thing you saw today?";
    public string _prompt02 ="What was the biggest emotion from today?";
    public string _prompt03="Where were you today?";
    public string _prompt04="If you could redo one thing today what would it be?";
    public string _prompt05="who did you talk to today?";

    public RandomPrompt()
    {
        
    }    

    public void displayprompt()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1,6);
        
        string filename = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        if (num == 1)
        {
            Console.WriteLine($"{_prompt01}");
            outputFile.WriteLine($"{_prompt01}");
        }
        else if (num == 2)
        {
            Console.WriteLine($"{_prompt02}");
            outputFile.WriteLine($"{_prompt02}");
        }
        else if (num == 3)
        {
            Console.WriteLine($"{_prompt03}");
            outputFile.WriteLine($"{_prompt03}");
        }
        else if (num == 4)
        {
            Console.WriteLine($"{_prompt04}");
            outputFile.WriteLine($"{_prompt04}");
        }
        else if (num == 5)
        {
            Console.WriteLine($"{_prompt05}");
            outputFile.WriteLine($"{_prompt05}");
        }
        }
    }
    
}