using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
                        
        Entry anEntry = new Entry();
        anEntry._date = theCurrentTime.ToShortDateString();
        anEntry._promptText = "";
        anEntry._entryText = "";
                       
        
        anEntry.Display();
        
        
        PromptGenerator aPrompt = new PromptGenerator();
        aPrompt._prompts = new List<string>();
        aPrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        aPrompt._prompts.Add("What was the best part of my day?");
        aPrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        aPrompt._prompts.Add("What was the strongest emotion I felt today?");
        aPrompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        Journal theJournal = new Journal();
        theJournal._entries = new List<Entry>();
        //theJournal._entries.Add(anEntry);
        //theJournal.DisplayAll();

        string userChoice = "0";
        

            while (userChoice != "5")
            {
                Console.WriteLine("Please select one of the following choices:" );
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Entry newEntry = new Entry();
                    newEntry._date = theCurrentTime.ToShortDateString();
                             
                    newEntry._promptText = aPrompt.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    newEntry._entryText = Console.ReadLine();
                    theJournal._entries.Add(newEntry);

                }

                else if (userChoice == "2")
                {
                    theJournal.DisplayAll();
                }

                else if (userChoice == "3")
                {
                    theJournal.LoadFromFile();
                }


                else if (userChoice == "4")
                {
                    Console.WriteLine("The file name is Journal.csv");
                    theJournal.SaveToFile();
                }

            }







    }
}