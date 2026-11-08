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

    public ReflectionActitity()
    : base ("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {}
    public void TheReflectionActitity()
    {
        DisplayStartMessage();
        
        
        if (_duration <= 0) 
        {
            _duration = 10; 
        }

        Random random = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.Clear();

        string randomPrompt = _prompt[random.Next(_prompt.Count)];
        Console.WriteLine($"{randomPrompt}\n");
        Console.WriteLine("Press enter when you are ready...");
        Console.ReadLine();

        Console.Clear();
        DisplaySpinnerMessage("next question", 3);
        Console.Clear(); 

        while (DateTime.Now < endTime)
        {
            string randomQuestion = _questions[random.Next(_questions.Count)];
      
            Console.WriteLine($"\n> {randomQuestion}\n");


            DisplaySpinnerMessage("next question", 5);

            if (DateTime.Now >= endTime) break;
        }

        EndActivity();
    }
}