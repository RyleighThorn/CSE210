using System.ComponentModel;

class Doctor : Person
{
    private string _tools;
    public Doctor (string firstName, string lastName, int age, double weight, string tools)
    : base (firstName, lastName, age, weight)
    {
        _tools = tools;
    }
    public override string GetPersonInfo()
    {
        return $"Doctor: tools: {_tools}, {base.GetPersonInfo()}"; //base make sure it calls this person info
    }
    public override double GetSalary()
    {
        return 200.00;
    }
}