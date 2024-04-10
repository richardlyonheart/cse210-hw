using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Console.Clear();
        List<Event> events = new List<Event> ();
        
        Lecture lecture = new Lecture("How to be Iron man", "Begin by blah blah", "04-09-24", "10:00", "123 street name", "City", "TX", "United States", "Iron Man", 21);
        events.Add(lecture);
        
        Outdoor outdoorEvent = new Outdoor("Planking party", "Time to plank the park", "05-10-24", "12:00", "123 park street", "City", "TX", "United States", "Cloudy");
        events.Add(outdoorEvent);

        Reception reception = new Reception("Marriage", "You are invited to our wedding, more details will be provided with the RSVP", "10-01-2024", "6:00", "123 street name", "City", "TX", "United States", "Emailme@here.com");
        events.Add(reception);

        foreach (Event activity in events)
        {
            Console.WriteLine("<----- EVENT ----->\n");
            Console.WriteLine("\n/*** STANDARD DETAILS ***/");
            Console.WriteLine(activity.GetStandardDetails());
            Console.WriteLine("\n/*** FULL DETAILS ***/");
            Console.WriteLine(activity.GetFullDetails());
            Console.WriteLine("\n/*** SHORT DETAILS ***/");
            Console.WriteLine($"{activity.GetShortDescription()}\n");
        }
        
    }
}