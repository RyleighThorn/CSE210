class SimpleGoal : BaseGoal
{

    public SimpleGoal(string name, string description, int points, bool status, string goalType)
    : base (name, description, points, status, goalType)
    {
        //dont need anything here
    }
    public SimpleGoal() : base("SimpleGoal")
    {//call here when working iwth the UI
    }
    public override int RecordEvent()
    {
        return MarkComplete();
    }
}