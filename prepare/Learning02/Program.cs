using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {

        Job job1 = new Job();
        job1._jobTitle = "Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2022;

        job1.display();

        Job job2 = new Job();
        job2._jobTitle = "Softwear Engineer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2025;

        job2.display();

        Resume myResume = new Resume();
        myResume._name = "Ryleigh";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.DisplayResume();


    }
}