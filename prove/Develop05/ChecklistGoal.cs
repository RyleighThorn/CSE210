using System.Runtime;
using System.Security.Cryptography.X509Certificates;

class ChecklistGoal : BaseGoal
{
    private int _target;
    private int _bonus;

    public int _amountCompleted;
    public ChecklistGoal(string name, string description, int points, bool status, string goalType, int target, int bonus, int amountCompleted)
    : base (name, description, points, status, goalType)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _amountCompleted = 0;
    }
    private void SetTargetGoal()
    {
        Console.Write("How many times does this goal need to be done to be acomplished: ");
        _target = int.Parse(Console.ReadLine());
    }

    private void SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times: ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public ChecklistGoal() : base("ChecklistGoal")
    {
        SetTargetGoal();
        SetBonusPoints();
        
    }
    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()} --- Currently Completed {_amountCompleted}/{_target}";
    }


    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted > _target)
        {
            return 0;
        }else if(_amountCompleted == _target)
        {
            MarkComplete();
            return _bonus + _points;
        }
        return _points;
    }
    public override string getSavedString()
    {
        bool completed = false;
        if (_status)
            completed = true;
        return $"{_goalType},{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted},{completed}";
    }
}