using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());
        */
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int response = -1;
        int times = 0;

        while (response != magicNumber)
        {
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());
            times ++;
 
                if (response > magicNumber)
                {
                    Console.WriteLine("Lower");
                                        
                }
                else if (response < magicNumber)
                {
                    Console.WriteLine("Higher");
                    
                }
        
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.Write($"You attempt {times} times.");
                }
        }
        
    }
}