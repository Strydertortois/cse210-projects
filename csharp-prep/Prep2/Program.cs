using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
                else if (percent >= 70)
        {
            letter = "C";
        }
                else if (percent >= 60)
        {
            letter = "D";
        }
                else if (percent <= 50)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

                if (percent >= 70)
                {
                    Console.WriteLine("Congrats! you passed!");
                }
                else 
                {
                    Console.WriteLine("Sorry, Better luck next time");
                }
    }
}