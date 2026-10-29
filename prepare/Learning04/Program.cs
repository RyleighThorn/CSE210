using System.Security.AccessControl;
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        Math a2 = new Math("Roberto Rodriguez", "fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomework());

        Writing a3 = new Writing("Mary Waters", "European History", "The Causes of World War 2");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}