using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string firstname;
        string lastname;
        Console.Write("please enter your first name: ");
        firstname = Console.ReadLine();
        Console.Write("please enter your last name: ");
        lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

        int x = 10;

        if (x == 10){
            Console.WriteLine("X yay");
            Console.WriteLine("Y also yay");
        }
        


    }
}
