using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your percentage grade: ");
        string user_grade = Console.ReadLine();
        int x = int.Parse(user_grade);

        if (x >= 90 && x <= 100)
        {
            letter = "A";
        } else if (x >= 81 && x <= 89)
        {
            letter = "B";
        } else if (x >= 71 && x <= 79)
        {
            letter = "C";
        } else if (x >= 61 && x <= 69)
        {
            letter = "D";
        } else if (x >= 0 && x < 60)
        {
            letter = "F";
        }
        else{
            Console.Write("Not usable answer");
        }
        Console.WriteLine($" Your grade is {letter}");
        if (x >= 70)
        {
            Console.Write("Congrats you passed!");
        }
        else
        {
            Console.Write("You failed, better luck next time");
        }
    }
}