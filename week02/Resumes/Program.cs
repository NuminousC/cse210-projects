
using System;

class Program
{
    static void Main()
    {
        // Create the first instance of job
        Job job1 = new Job();

        job1._company = "Opay";
        job1._jobTitle = "Dev";
        job1._startYear = 2017;
        job1._endYear = 2020;

        // Create the second instance job
        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2021;
        job2._endYear = 2023;


        // Create a resume
        Resume myResume = new Resume();

        // Set the person's name
        myResume._name = "Allison Rose";

        // Add the jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the complete resume
        myResume.Display();
    }
}
