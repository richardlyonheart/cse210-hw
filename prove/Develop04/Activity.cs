using System.ComponentModel;
using System.Dynamic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public virtual void Start()
    {
        Console.Clear();
        Spinner();
        Console.Clear();
        Console.WriteLine($"Welcome to {_name} activity!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nPlease enter the duration in seconds: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nGet ready...");
        Spinner();
        Thread.Sleep(3000);
    }
 public virtual void End()
    {
        Console.WriteLine($"\nGreat job! You've completed the {_name} activity.");
        Console.WriteLine($"\nDuration: {_duration} seconds");
        Thread.Sleep(3000);
    }

    public void Spinner()
    {
        string[] spinnerChars = { "-", "\\", "|", "/" };
        int iterations = 2;

        for (int i = 0; i < iterations; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c + "\r");
                Thread.Sleep(250);
            }
        }

        Console.WriteLine(); // Readability
    }

    // Counting down till end
    public void Counter(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000); // Wait for 1 second
            seconds--;
            Console.Write("\b \b");
        }
    }
}
