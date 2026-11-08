using System.ComponentModel;
using System.Diagnostics;

class ListingActitity : BaseActivity
{
    private List<string> _prompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActitity()
    : base ("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

public void TheListingActitity()
    {
        DisplayStartMessage();
        if (_duration <= 0) 
        {
            _duration = 10; 
        }
        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.Clear(); 
        Console.WriteLine("List as many answers as you would like:\n");

        string randomPrompt = _prompt[random.Next(_prompt.Count)];
        Console.WriteLine($"{randomPrompt}");
        Console.WriteLine("Press Enter when you are ready");
        Console.ReadLine();

        Console.Clear(); 
        DisplaySpinnerMessage("Get ready", 3); 
        Console.Clear();

        List<string> _items = new List<string>();

        
        Console.WriteLine($"{randomPrompt}");
        Console.WriteLine("Start listing items (press Enter after each one):\n");

        while (DateTime.Now < endTime)
        {
           
            if (DateTime.Now >= endTime) break;

            Console.Write("");
            
            
            string input = Console.ReadLine();

       
            if (DateTime.Now >= endTime) break;

            if (!string.IsNullOrWhiteSpace(input))
            {
                _items.Add(input);
            }
        }

        Console.WriteLine($"\n{_items.Count}");
        Thread.Sleep(3000); 

        EndActivity();
    }

}
