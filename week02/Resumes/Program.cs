using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Blizzard Entertainment";
        job1._jobTitle = "Jr. Software Engineer";
        job1._startYear = "2005";
        job1._endYear = "2008";

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = "2008";
        job2._endYear = "2025";


        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "John Doe";

        myResume.Display();

    }
}