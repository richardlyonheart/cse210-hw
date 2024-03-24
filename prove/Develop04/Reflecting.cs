using System;

public class Reflecting : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflecting()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect";
    }

    public override void Start()
    {
        base.Start();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            string prompt = _prompts[rand.Next(_prompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            Counter(3);

            DateTime questionsEndTime = DateTime.Now.AddSeconds(_duration); // Calculate end time for questions
            while (DateTime.Now < questionsEndTime) // Loop for asking questions within duration
            {
                foreach (var question in _reflectionQuestions)
                {
                    Console.WriteLine(question);
                    Console.WriteLine();
                    Counter(5);
                    if (DateTime.Now >= questionsEndTime) // Check if it's time to exit questions loop
                        break;
                }
            }

            if (DateTime.Now >= endTime) // Check if it's time to exit the main activity loop
                break;
        }
        End();
    }
}