using System.ComponentModel.Design.Serialization;

class BaseActivity
{
    //add attributes
    private string _name;
    private string _description;
    protected int _duration;
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        //_endTime = endTime;

    }

    public void EndActivity()
    {
        DisplaySpinnerMessage("\nWell done!", 3);
        Console.WriteLine($"\nYou have done {_duration} seconds of the {_name} activity!");
        
    }
    
    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false; // to make it look nicer during the countdown
        for(int i=seconds; i>=1; i--){ //loop start at 5 and count down, do -- to get down

        Console.Clear(); //clears screen every time
        Console.Write($"{message} - {i}"); //this message
        Thread.Sleep(1000); //puts the program to sleep for this long (1sec)
        }
        Console.CursorVisible = true;
    }

    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message}");
        DateTime endTime = DateTime.Now.AddSeconds(seconds); //will get current time and endtime should be set to 10
        //will be at rount of well done on other file
        //for (int i=0; i < seconds; i++)
        while(DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");

        }
        Console.Clear();
        Console.Write($"{message}");
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine($"{_description}");

        ObtainDuration();

        Console.Clear();
        RunCountDownMessage("Get ready", 3);
    }
    public void ObtainDuration()
    {
        //_duration = duration;
        Console.WriteLine("How long should this activity last in seconds? ");
        _duration = int.Parse(Console.ReadLine());
        
    }
}
