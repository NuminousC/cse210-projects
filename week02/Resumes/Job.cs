
using System;

public class Job
{
    // Attributes: information about the job
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Behavior: display the job information
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
