using System;
using System.Security.Cryptography;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            // Menu options to choose from
            Console.WriteLine("Menu:");
            Console.WriteLine("A. Write a new entry");
            Console.WriteLine("B. Display your journal");
            Console.WriteLine("C. Save your journal to a file");
            Console.WriteLine("D. Load your journal from a file");
            Console.WriteLine("E. Exit");
            Console.Write("Begin typing: ");

            string choice = Console.ReadLine();

            // Prompts user with a  random question for a journal entry
            if (choice == "A") 
            {
                string prompt = RandomPrompt.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                string response = GetUserResponse();

                Entry newEntry = new Entry(prompt, response, DateTime.Now.ToString());
                journal.AddEntry(newEntry);
            }
            
            // Shows user previously input journal entries
            else if (choice == "B")
            {
                Console.WriteLine("Journal Entries:\n");
                journal.DisplayEntries();
            }

            // Prompts user for a file name and then saves file
            else if (choice == "C")
            {
                Console.Write("Enter file name to save: ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }

            // file name to load into the journal
            else if (choice == "D")
            {
                Console.Write("Enter file name to load: ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);
            }

            // Exits the program
            else if (choice == "E")
            {
                Environment.Exit(0);
            }

            // User input invalid menu option
            else
            {
                Console.WriteLine("Invalid choice. Please try again. Try Upper Case letters please");
            }

            Console.WriteLine();  // Add a line break for readability
        }
    }

    public static string GetUserResponse()
    {
        Console.Write("You wrote ");
        return Console.ReadLine();
    }

}