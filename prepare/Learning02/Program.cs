using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Lenovo";
        job1._start = 2020;
        job1._end = 2023;

        Job job2 = new Job();
        job2._jobTitle = "master desinger";
        job2._jobCompany = "Disney";
        job2._start = 2009;
        job2._end = 2019;

        Resume resume = new Resume();
        resume._membername = "Brenden Lyon";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //job1.ShowJob();
        //job2.ShowJob();
        resume.DisplayResume();

    }
}