using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Displaywelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
         // remember that useryear/name/number does not need to match
        //what is in the function only represent what we need to help up here
        int usersquare = SquareNumber(usernumber);

        //int year;
        PromptUserBirthYear(out int year); //does not need to be changed as the year is taken as it is
        DisplayResult(usersquare, year, username);

    }
    static void Displaywelcome()
        {
           Console.WriteLine("Welcome to the program!"); 
        }
    static string PromptUserName()
        {
        Console.WriteLine("please enter your name: ");
        string name = Console.ReadLine();
            return name;
        }
    static int PromptUserNumber()
        {
        //string x = "";
           Console.Write("please enter your favorite number: ");
            //x = Console.ReadLine(); one way you can do it
            int number = int.Parse(Console.ReadLine()); 
            return number;
        }
    static void PromptUserBirthYear(out int year)//not int, it needs
    //to be reworked above and it doesnt work if its an int
    //that is also why you dont need to return, its in the
    //parameters so the out can still work
        {
            //string y = "";
            Console.WriteLine("please enter the year you where born: ");
            //y = Console.ReadLine();
            year = int.Parse(Console.ReadLine());
            //return year;
        }

    static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
    static void DisplayResult(int square, int year, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
            int age = 2026 - year;
            Console.WriteLine($"{name}, you will turn {age} this year");
        }
}