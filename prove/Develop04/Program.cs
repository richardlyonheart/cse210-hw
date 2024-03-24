using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        int choice;
        do
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exersize Activity");
            Console.WriteLine("5. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            Activity activity;

            if (choice == 1)
            {
                Console.Clear();
                activity = new Breathing();
                activity.Spinner();
                activity.Start();
            }
            else if (choice == 2)
            {
                Console.Clear();
                activity = new Reflecting();
                activity.Spinner();
                activity.Start();
            }
            else if (choice == 3)
            {
                Console.Clear();
                activity = new Listing();
                activity.Spinner();
                activity.Start();
            }
             else if (choice == 4)
            {
                Console.Clear();
                activity = new Exersize();
                activity.Spinner();
                activity.Start();
            }
            else if (choice == 5)
            {
                Console.Clear();
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        } while (choice != 4);
    }
    
}/*I added spinners at multiple points and added an activity
that could be for setting up for daily exersize timer
*/