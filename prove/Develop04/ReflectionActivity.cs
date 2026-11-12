using System.ComponentModel;
using System.Diagnostics;

class ReflectionActitity : BaseActivity
{
    private List<string> _prompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActitity(string name, string description)
    : base (name, description)
    {}
    public void RunReflectionActitity(){
        DisplayStartMessage();

        Random random = new Random();
        
        Console.Clear();

        string randomPrompt = _prompt[random.Next(_prompt.Count)]; //work on this part
        Console.WriteLine("Consiter the prompt");
        Console.WriteLine($"_____{randomPrompt}_____\n");
        Console.WriteLine("Press enter when you are ready");
        Console.ReadLine();

        Console.Clear();
        RunCountDownMessage("Now ponder each of the following questions as it relates to the prompt", 5);
        Console.Clear(); 

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)//seems to count the above display spinner message as part of the loop countdown 
        {
            string randomQuestion = _questions[random.Next(_questions.Count)];


            DisplaySpinnerMessage($"{randomQuestion}", 7);


            if (DateTime.Now >= endTime) break;
        }

        EndActivity();
    }
}