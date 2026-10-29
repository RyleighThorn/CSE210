using System.Security.AccessControl;
using System;

class Assignment
{
    private string _topic;
    private string _studentName;

    public Assignment(string topic, string studentName)
    {
        _studentName = studentName;
        _topic = topic;

    }
    public string GetName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}