public class Resume
{
    public string _name = "";
    //List<string> Job = new List<string>();
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name} \n Job: \n");

        foreach (Job job in _jobs)
        {

            job.display();
        }
    }

}