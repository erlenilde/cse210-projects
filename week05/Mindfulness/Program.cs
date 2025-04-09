using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        

            while (userChoice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Start breathing activity");
                Console.WriteLine(" 2. Start reflecting activity");
                Console.WriteLine(" 3. Start listing activity");
                Console.WriteLine(" 4. Quit");
                Console.Write("Select a choice from the menu: ");
                userChoice = Console.ReadLine();

                Console.Clear();

                if (userChoice == "1")
                {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                }

                else if (userChoice == "2")
                {
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                }

                else if (userChoice == "3")
                {
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                }

                else if (userChoice == "4")
                {
                    Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                }

                else
                {
                    Console.WriteLine("Invalid option. Please select a number between 1 and 4.");
                }

                if (userChoice != "4")
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
                
            }
    }
}