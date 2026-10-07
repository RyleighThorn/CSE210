using System;
public class Job
{
    public string _jobTitle;
    
    public string _company;
    
    public int _startYear;
    public int _endYear;

    public List<Job> _jobs = new List<Job>();

    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({_company} \n{_startYear} {_endYear})");
    }
}
