using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

            string userName = UserName();
            int userNumber = UserNumber();
            int SquareNumber = SquaredNumber(userNumber);

     

        Result(userName, SquareNumber);


    }   

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string UserName()
    {
        Console.WriteLine("Tell us your name: ");
        string username = Console.ReadLine();

        return username;
    }

    static int UserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int usernumber = int.Parse(Console.ReadLine());

        return usernumber;
    }

    static int SquaredNumber(int usernumber)
    {
        int square = usernumber * usernumber;

        return square;
    }

    static void Result(string username, int square)
    {
        Console.WriteLine($"Brother {username}, the square of your number is {square}");
        
    }
}