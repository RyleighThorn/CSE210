using System.ComponentModel;
class Math: Assignment
{
    private string _testbookSection;
    private string _problems;

    public Math(string studentName, string topic, string testbookSection, string problems)
    : base (studentName, topic)
    {
        _testbookSection = testbookSection;
        _problems = problems;
    }
    public string GetHomework()
    {
        return $"section: {_testbookSection} problems : {_problems}";
    }
}