using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Erlenilde", "Chemistry");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Erlenilde", "Chemistry", "8.2", "10-20");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());    
                       
        WritingAssignment writingAssignment = new WritingAssignment("Erlenilde", "Chemistry", "How thermodynamics works");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        
    }
}