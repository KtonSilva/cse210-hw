using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Test Job class
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Displaying job details using Display method
        job1.Display();
        job2.Display();

        // Test Resume class
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Adding jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displaying resume details using Display method
        myResume.Display();
    }
}