class Police : Person
{
    string _weapons;
    public Police(string firstName, string lastName, int age, double weight, string weapons)
    : base (firstName, lastName, age, weight) 
    {
        _weapons = weapons;
    }
    public override string GetPersonInfo() //if its not generic person override it with this
    {
        return $"Police: weaponds: {_weapons}, {base.GetPersonInfo()}";
    }
    public override double GetSalary()
    {
        return 150.00;
    }
}