using System.ComponentModel;
using System.Diagnostics;

class BreathingActitity : BaseActivity
{
    public BreathingActitity()
    : base ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}//for the other two there will be a prompt and list here

    public void BreathingActivity(){
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime) // check timer then breathe in and breathe out
        {

            RunCountDownMessage("Breathe in ....", 4); //guts of breathing activity
            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out .... ", 6);
            Console.WriteLine();


    }
    EndActivity();
        }

    }

