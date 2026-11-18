using System;

class Program
{
    static void Main(string[] args)
    {
        //BaseGoal myBaseGoal = new BaseGoal(); can no longer do this now we do it through simple goal
        //Console.WriteLine(myBaseGoal.GetConsoleString()); the thing below does the same thing
        //we need something to define what goal it is so it knows what to go to, i think this is menue/case deal
        SimpleGoal mySimpleGoal = new SimpleGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
        mySimpleGoal.RecordEvent();     //all debug code lol throw away
        Console.WriteLine(mySimpleGoal.GetConsoleString());

    }
}