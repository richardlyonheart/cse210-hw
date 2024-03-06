using System.IO.Pipes;

public class Job
{
    public string _jobTitle;
    public string _jobCompany;
    public int _start;
    public int _end;

    public Job()
    {}
    public void ShowJob()
    {
        Console.WriteLine($"{_jobTitle}, ({_jobCompany}), {_start}-{_end}");
    }
}