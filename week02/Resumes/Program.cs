using System;

class Program
{
    static void Main(string[] args)

    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2026;
        job1._endYear = 2029;


        Job job2 = new Job();
        job2._jobTitle = "Forensic Scientist";
        job2._companyName = "Expert Laboratory services";
        job2._startYear = 2021;
        job2._endYear = 2026;


        Job job3 = new Job();
        job3._jobTitle = "Toxicologist";
        job3._companyName = "Forensic Toxicoloy Laboratory";
        job3._startYear = 2019;
        job3._endYear = 2021;

        Resume myResume = new Resume();
        myResume._givenName = "Nompilo Ngwenya";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);


        myResume.Display();
    }
}