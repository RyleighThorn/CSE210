using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;

        Console.WriteLine("Welcome to the mindfulness activity");

         while(loop){//make the loop so it keeps hiding words until you press q for quit
        Console.WriteLine("");
        Console.WriteLine("type in a number for what you want");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. quit");
        Console.WriteLine("Pick an option: ");
        string input = Console.ReadLine().ToLower();
        if (input == "1")
            {
                BreathingActitity breathe = new BreathingActitity(); 
                breathe.BreathingActivity();
            }else if(input == "2")
            {
                ReflectionActitity reflection = new ReflectionActitity(); 
                reflection.TheReflectionActitity();
            }
            else if(input == "3")
            {
                ListingActitity listing = new ListingActitity(); 
                listing.TheListingActitity();
            }
            else if (input == "4")
            {
                Console.WriteLine("Thank you!");
                loop = false;
            }
            else
            {
                Console.WriteLine("that is not a correct option");
                Console.ReadLine();
                
            }
    }
    }
}