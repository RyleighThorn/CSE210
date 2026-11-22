class EternalGoal : BaseGoal
{

    public EternalGoal(string name, string description, int points, bool status, string goalType)
    : base (name, description, points, status, goalType)
    {
    }

    public EternalGoal() : base("EternalGoal")
    {
    }
    public override int RecordEvent()
    {
        return _points;
        //need multiple repeating points do you cant do just mark complete

    }
    public override string getSavedString()
    {
        return $"{_goalType},{_name},{_description},{_points}";
    }
}