using System;
public class Breathing : Activity
{
    public Breathing()
        {
            _name = "Breathing";
            _description = "This activity will help with a breathing exersize.";
        }
    public override void Start()
    {
        base.Start();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Clear your mind and focus on breathing.");

        while (DateTime.Now <endTime)
        {
            Console.Write("\nBreathe In   ");
            Counter(6);
            Console.Write("\nBreathe out   ");
            Counter(4);
            Console.WriteLine();
        }
        End();
    }
}
