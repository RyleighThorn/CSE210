using System;

class Program
{

    static double AddNumbers(double x, int y)
    {
        return x + y;
    }

    static void displaygreeting(string name)
    {
        Console.WriteLine($"welcome {name}, pleased to mee you");
    }
    static void Main(string[] args)

    {
        displaygreeting("bob");
        double answer = AddNumbers(12.234, 10); //same thing as below
        //Console.WriteLine(AddNumbers(12.234, 10));
        Console.WriteLine(answer);
        
        /*Console.WriteLine("bonjor mi amigos");
        Console.WriteLine("Hello");
        Console.WriteLine("hey betty");*/

        /*bool done;
            do
            {
                Console.Write("done(y/n)");
                done = Console.ReadLine().ToLower() == "y";
            } while (!done);*/


    //counting!
    /*for (double i = 0; i < 10; i+= 5.34) //doing double instead of int allows for decimals
        {
            Console.WriteLine($"{i} -");

           // Console.WriteLine(i);*/

//add names on a list
           /*List<string> myFriends = ["bob", "bill", "gargameth"];
           List<string> names = new List<string>();
           myFriends.Add("henrrrrrrry");
           myFriends.Add("voldemort");

           foreach(string name in myFriends)
        {
            Console.WriteLine(name);
        }*/
    }
}
