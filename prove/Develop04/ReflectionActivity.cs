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
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        Console.Clear();

        string randomPrompt = _prompt[random.Next(_prompt.Length?)]; //work on this part
        Console.WriteLine($"{randomPrompt}\n");
        Console.WriteLine("Press enter when you are ready");
        Console.ReadLine();

        Console.Clear();
        DisplaySpinnerMessage("Get ready...", 3);
        Console.Clear(); 

        while (DateTime.Now < endTime)//seems to repeat the part above with writeline after doing prompt 
        {//dont need to type responces just show 3 different 
            string randomQuestion = _questions[random.Next(_questions.Count)];
      
            Console.WriteLine($"\n> {randomQuestion}\n");


            DisplaySpinnerMessage("next question", 3);


            if (DateTime.Now >= endTime) break;
        }

        EndActivity();
    }
}