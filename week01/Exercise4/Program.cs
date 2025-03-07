using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();

        int userInput = -1;
        int sum = 0;
        
        
       
        while (userInput != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            userInput = int.Parse(Console.ReadLine());
            

            if (userInput != 0)
            {
                numbers.Add(userInput);
                
            }
        }
      
        foreach (int number in numbers)
        {
            sum += number; 
            
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
        if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");    
        
        

    }
}