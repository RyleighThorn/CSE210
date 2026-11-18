using System.ComponentModel.Design.Serialization;
using System;
using System.Drawing;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;
    public BaseGoal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _goalType = goalType;
    }

    public BaseGoal(string goalType)
    {
        SetGoalName();
        SetGoalDescription();
        SetGoalPoints();
        _status = false; // so when used its audomatically not completed
        //_goalType = base.ToString(); // reference to base object, it audomatically does it to simple goal
        _goalType = goalType;//so now in menu you ask for what you want and then back in the goal you want 
        //it passes the string you want, just need to promt which file it checks to
    }

    private void SetGoalName()
    {
        Console.Write("Please enter the name of your goal: ");
        _name = Console.ReadLine();
    }
        //you can combine name, description, and attributes of a goal
    private void SetGoalDescription()
    {
        Console.Write("Please enter the description of your goal: ");
        _description = Console.ReadLine();
    }
    private void SetGoalPoints()
    {
        Console.Write("Please enter the amount of points for your goal: ");
        _points = int.Parse(Console.ReadLine());
    }
    public virtual string GetConsoleString()
    {
        string completeString = " ";
        if (_status)
            completeString = "X";
        return $"[{completeString}] - {_goalType} - Goal name: {_name}, Description: {_description}, Points: {_points}";
    }
    public int MarkComplete()
    {
        _status = true;
        return _points;
    }

    public abstract int RecordEvent(); //now use this in the other goals to override specifically what they are going to do
    //need to make the class abstract

}