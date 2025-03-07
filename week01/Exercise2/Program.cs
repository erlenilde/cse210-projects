using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which is your grade percentage?");
        string studentGrade = Console.ReadLine();
        int studentGradeNumber = int.Parse(studentGrade);
        string letter = "";

        /*if (studentGradeNumber >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else if (studentGradeNumber >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else if (studentGradeNumber >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else if (studentGradeNumber >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
            Console.WriteLine("Sorry, you must try this class again");
        }
        else if (studentGradeNumber < 60)
        {
            Console.WriteLine("Your letter grade is F.");
            Console.WriteLine("Sorry, you must try this class again");
        }*/

        if (studentGradeNumber >= 90)
        {
            letter = "A";
        }
        else if (studentGradeNumber >= 80)
        {
            letter = "B";
        }
        else if (studentGradeNumber >= 70)
        {
            letter = "C";
        }
        else if (studentGradeNumber >= 60)
        {
            letter = "D";
        }
        else if (studentGradeNumber < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (studentGradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.Write("Better luck next time!");
        }
    }
}