using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startDate = 2020;
        job1._endDate = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Game Developer";
        job2._company = "Nintendo";
        job2._startDate = 2022;
        job2._endDate = 2024;

        Resume resume = new Resume();
        resume._name = "Matthew Gifford";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}