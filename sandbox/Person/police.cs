class Police : Person
{
    string _weapons;
    public Police(string firstName, string lastName, int age, double weight, string weapons)
    : base (firstName, lastName, age, weight) 
    {
        _weapons = weapons;
    }
    public string GetPoliceInfo()
    {
        return $"Police: weaponds: {_weapons}, {GetPersonInfo()}";
    }
}