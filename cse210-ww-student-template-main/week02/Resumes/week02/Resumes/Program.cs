using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Newegg";
        job1._startYear = "2018";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Customer Service Representative";
        job2._company = "Microsoft";
        job2._startYear = "2020";
        job2._endYear = "2021";

        Resume myResume = new Resume();
        myResume._name = "Myra Winters";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        Console.WriteLine("Hello World! This is the Journal Project.");
    }
}