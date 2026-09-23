using System;

class Program
{
    static void Main(string[] args)
    {

        string user_guess = "";

        Random randomGen = new Random();
        int number = randomGen.Next (1, 10);
        //string magic_number = "";
       /* Console.Write("What is the magic number? ");
        magic_number = Console.ReadLine();
        int y = int.Parse(magic_number);*/

        bool gamewin = false;

        while (gamewin != true){
        Console.Write("What is your guess? ");
        user_guess = Console.ReadLine();
        int x = int.Parse(user_guess);

        if (x > number)
        {
            Console.WriteLine("lower");
        } else if (x < number)
        {
            Console.WriteLine("higher");
        } else if (x == number)
        {
            Console.WriteLine("You got it!");
            gamewin = true;
        }
        else
        {
            Console.WriteLine("answer is not usable, try another number");
        }
        }
    }
}