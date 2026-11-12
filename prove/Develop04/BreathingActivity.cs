using System.ComponentModel;
using System.Diagnostics;

class BreathingActitity : BaseActivity
{
    public BreathingActitity(string name, string description)
    : base (name, description)
    {}//for the other two there will be a prompt and list here

    public void RunBreathingActivity(){
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) // check timer then breathe in and breathe out
        {

            RunCountDownMessage("Breathe in ....", 4); //runs this twice, why?
            if (DateTime.Now >= endTime) break; //if duration set time is up then break

            RunCountDownMessage("Breathe out .... ", 6);
            if (DateTime.Now >= endTime) break;
            Console.WriteLine();


    }
        EndActivity();
        }

    }

