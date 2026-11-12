using System.ComponentModel;
using System.Diagnostics;

class ListingActitity : BaseActivity
{
    private List<string> _prompt2 = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActitity(string name, string description)
    : base (name, description)
    {}

public void RunListingActitity(){
         DisplayStartMessage();

        Random random = new Random();
        
        Console.Clear();

        string randomPrompt = _prompt2[random.Next(_prompt2.Count)]; //work on this part
        Console.WriteLine("Consiter the prompt");
        Console.WriteLine($"_____{randomPrompt}_____\n");
        Console.WriteLine("Press enter when you are ready");
        Console.ReadLine();

        RunCountDownMessage("You may start in:", 5);
        List<string> _items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) // similar issue as before but you need to make sure it stores it as a list
        {
            //List<string> _items = new List<string>();
           
            if (DateTime.Now >= endTime) break;
            Console.WriteLine("");
            Console.Write("> ");
            //Console.ReadLine();

            string input = Console.ReadLine();

            if (DateTime.Now >= endTime) break;


            if (!string.IsNullOrWhiteSpace(input))
            {
                _items.Add(input);
            }
            if (DateTime.Now >= endTime) break; 
        }
        Console.WriteLine($"\nTimes up! You have {_items.Count} items in your list.");
        Thread.Sleep(3000); 

        EndActivity();
    }

}
