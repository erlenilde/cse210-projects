using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Operator";
        job1._company = "Gerdau";
        job1._startYear = 2005;
        job1._endYear = 2008;

        Job job2 = new Job();
        job2._jobTitle = "Technician";
        job2._company = "Gerdau";
        job2._startYear = 2008;
        job2._endYear = 2010;

        /*
        job1.Display();
        job2.Display();
        */


        Resume myResume = new Resume();
           
        myResume._name = "Erlenilde Santos";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}