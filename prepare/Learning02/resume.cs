using system;


public class Resume
{
    public string _name;

    public List<job> _jobs = new List<job>();

    public Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }
}