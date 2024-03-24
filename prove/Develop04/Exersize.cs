using System;
public class Exersize : Activity
{
    public Exersize()
        {
            _name = "Exersize";
            _description = "This activity will help as a timer for basic exersizing, try to get as many reps in between pauses.";
        }
    public override void Start()
    {
        base.Start();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Lets go!");

        while (DateTime.Now <endTime)
        {
            Console.Write("\nBegin  ");
            Counter(9);
            Console.Write("\nPause  ");
            Counter(4);
            Console.WriteLine();
        }
        End();
    }
}
