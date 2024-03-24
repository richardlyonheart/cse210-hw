using System;

public class Listing : Activity
{
    private string[] _listingPrompts = {
        "How many birds and what kinds did you see today?",
        "What did you get done today?",
        "Who did you wish you could help?",
        "When have you felt the Holy Ghost recently?",
        "Where do you plan to be tomorrow?"
    };

    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life.";
    }

    public override void Start()
    {
        base.Start();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Thread.Sleep(3000);

        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            string prompt = _listingPrompts[rand.Next(_listingPrompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            Counter(3);
            

            Console.WriteLine("Start your list");

            int itemCount = 0;
            while (DateTime.Now < endTime) 
            {
                string input = Console.ReadLine(); // Take user input for an item
                if (!string.IsNullOrEmpty(input)) // Check if input is not empty
                {
                    itemCount++;
                }
                else
                {
                    Console.WriteLine("Item added. Press enter to add more items or wait for the activity to end.");
                    break;
                }
            }

            Console.WriteLine("Number of items listed: " + itemCount);
            if (DateTime.Now >= endTime) 
                break;
        }

        End();
    }
}
