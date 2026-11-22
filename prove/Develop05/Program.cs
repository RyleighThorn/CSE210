using System;

class Program
{
    static void Main(string[] args)
    {

        List<BaseGoal> goals = new List<BaseGoal>();
        Goals userInput = new Goals(); 

        bool loop = true;

        while (loop){
            Console.WriteLine($"You have {userInput.GetScore()} points"); // call it from base goal?

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1.) Create New Goal");
        Console.WriteLine("2.) List Goals");
        Console.WriteLine("3.) Save Goals");
        Console.WriteLine("4.) Load Goals");
        Console.WriteLine("5.) Record Event");
        Console.WriteLine("6.) Quit");
        Console.WriteLine("Choose an option from the menu: ");
        string input = Console.ReadLine();
        if (input == "1")
        {
            Console.WriteLine("The Types Of Goals Are: ");
            Console.WriteLine("1.) Simple Goal");
            Console.WriteLine("2.) Enternal Goal");
            Console.WriteLine("3.) Checklist Goal");
            Console.WriteLine("What Type Of Goal Would You Like To Create: ");
            string inputTwo = Console.ReadLine();
            if (inputTwo == "1")
                {
                    SimpleGoal mySimpleGoal = new SimpleGoal();
                    userInput.AddGoal(mySimpleGoal);
                   
                }else if (inputTwo == "2")
                {
                    EternalGoal myEternalGoal = new EternalGoal();
                    userInput.AddGoal(myEternalGoal);
                }else if (inputTwo == "3")
                {
                    ChecklistGoal myChecklistGoal = new ChecklistGoal();
                    userInput.AddGoal(myChecklistGoal);
                }
                else
                {
                    Console.WriteLine("That answer is not viable, it must be a number.");
                    Console.WriteLine("Please try again.");
                    Console.ReadLine();
                }
            
        }else if (input == "2")
        {
            userInput.displayGoals();
        }else if (input == "3")
        {
            userInput.saveGoals();
        }else if (input == "4")
        {
            userInput.loadGoals();
        }else if (input == "5")
        {
            userInput.recordEvent();
        }else if (input == "6")
        {
            Console.WriteLine("Thank you! Goodbye");
                loop = false;
        }
        else
        {
            Console.WriteLine("That answer is not viable, it must be a number.");
            Console.WriteLine("Please try again.");
            Console.ReadLine();
        }


        }
    }
}