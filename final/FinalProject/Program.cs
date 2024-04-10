using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        AssetManager manager = new AssetManager();

        Console.Clear();
        bool EndProgram = false;

        while (!EndProgram)
        {
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. View Assets");
            Console.WriteLine("2. Record New Asset");
            Console.WriteLine("3. Save Assets to File");
            Console.WriteLine("4. Load Assets from File");
            Console.WriteLine("5. Quit");

            Console.WriteLine("\nSelect an Option:  ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                LoadingBar();
                switch (choice)
                {
                    case 1:
                    manager.DisplayAssets();
                    break;

                    case 2:
                    CreateNewAsset(manager);
                    break;

                    case 3:
                    Console.Write("Enter the File name to save");
                    string saveFileName = Console.ReadLine();
                    manager.SaveAsset(saveFileName);
                    break;

                    case 4:
                    EndProgram = true;
                    Console.WriteLine("thanks for using our program!");
                    break;

                }
            }
        }
        static void CreateNewAsset(AssetManager manager)
        {
            Console.WriteLine("\nSelect the type of asset: ");
            Console.WriteLine("1. Jewelry");
            Console.WriteLine("2. Car");
            Console.WriteLine("3. House");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Write("Enter a name for the Asset: ");
                string assetName = Console.ReadLine();

                Console.Write("Enter a description of the Asset: ");
                string assetDescription = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Value of the Jewel: ");
                        break;
                    case 2: 
                        Console.Write("Enter the year of the car:");
                        Console.Write("Enter the make of the car: ");
                        Console.Write("Enter the Model of the car: ");
                        Console.Write("Is the car for rent or personal use? ");
                        break;
                    case 3: 
                        Console.Write("Is the home a 1. Single family Home or 2. Multi family Home? ");
                        if (int.TryParse(Console.ReadLine(), out int choice1))
                        {
                            switch (choice1)
                            {
                                case 1: 
                                    Console.Write("how much is the house worth?");
                                    Console.Write("How much is the monthly payment?");
                                    Console.Write("How much is Rent/income? ");
                                    manager.AddAsset(new Assets(assetName, assetDescription));

                                    break;
                                case 2:
                                    Console.Write("how much does the building worth? ");
                                    Console.Write("How many rooms are filled? ");
                                    Console.Write("How many rooms are vacant? ");  
                                    Console.Write("what is the rent per room? ");
                                    Console.Write("What is the total monthly expenses for the building? ");
                                    break;
                            }
                        }    
                    break;
                }
            }
        }
        static void LoadingBar()
    {
        Console.Clear();

        Console.WriteLine("| Loading |");
        string[] spinnerChars = { "|~        |", "|~~~      |", "|~~~~~    |", "|~~~~~~~  |", "|~~~~~~~~~|" };
        int iterations = 1;

        for (int i = 0; i < iterations; i++)
        {
            foreach (var c in spinnerChars)
            {
                Console.Write(c + "\r");
                Thread.Sleep(250);
            }
        }
        
        Console.Clear();
        Console.WriteLine();
    }
    }
}