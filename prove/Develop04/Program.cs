using System;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;

        Console.WriteLine("Welcome to the mindfulness activity!");

         while(loop){//make the loop so it keeps hiding words until you press q for quit
        Console.WriteLine("");
        Console.WriteLine("Menu");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Pick an option by typing the correstponding number: ");
        string input = Console.ReadLine().ToLower();
        if (input == "1")
            {
                BreathingActitity breathe = new BreathingActitity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."); 
                breathe.RunBreathingActivity();
                
            }else if(input == "2")
            {
                ReflectionActitity reflection = new ReflectionActitity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."); 
                reflection.RunReflectionActitity();
                
            }
            else if(input == "3")
            {
                ListingActitity listing = new ListingActitity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."); 
                listing.RunListingActitity();
                
            }
            else if (input == "4")
            {
                Console.WriteLine("Thank you!");
                loop = false;
                
            }
            else
            {
                Console.WriteLine("that is not a correct option, try again");
                Console.ReadLine();
                
            }
    }
    }
}