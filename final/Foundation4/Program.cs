using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.Clear();
        List<Activity> activities = new List<Activity> ();
        Running running = new Running(8, "04 Apr 2024", 1);//time, date, distance
        activities.Add(running);
        
        Swimming swimming = new Swimming(20, "05 Apr 2024", 10);//time, date, laps
        activities.Add(swimming);

        Cycling cycling = new Cycling(45, "06 Apr 2024", 25);//time, date, speed
        activities.Add(cycling);
        foreach (Activity activity in activities)
        {
           Console.WriteLine($"{activity.GetSummary()}\n"); 
        }
    }
}