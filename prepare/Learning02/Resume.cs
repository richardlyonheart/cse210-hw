public class Resume
{
    public string _membername;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {}

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_membername}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.ShowJob();
        }
    }
}