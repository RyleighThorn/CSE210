using System.IO;
using System.IO.Enumeration;
using System.Xml.Serialization;
class Goals{
    private int _score;
    public int GetScore() { return _score; }//so the display of points on the front will work
    private List<BaseGoal> _goals = new List<BaseGoal>();

    public Goals()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
    }
public void AddGoal(BaseGoal goal)
{
    _goals.Add(goal);
}
public void loadGoals()
{
    Console.WriteLine("which file would you like to load from: ");
    string fileName = Console.ReadLine();
    string[] lines = File.ReadAllLines(fileName);//so it can actually print it out 
    if (!File.Exists(fileName))
{
    Console.WriteLine("File not found.");
    return;
}

    _goals.Clear(); // no dublicates
    _score = int.Parse(lines[0]);//lines is in save goals how do i bring it here

    for(int i = 1; i <lines.Length; i++)//loop for display
        {
            string[] parts = lines[i].Split(',');
            if(parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0]));
            }else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0]));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                 _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), parts[0], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
            }
        }

}

public void displayGoals()
{
    int count = 1;//this is to set the first count to 1 not 0
    if (_goals.Count == 0)
        {
            Console.WriteLine("You do not have any goals yet");
        }
        else
        {
            foreach(BaseGoal goal in _goals)
            {
                Console.WriteLine($"{count++}. {goal.GetConsoleString()}");
            }
        }
}

public void saveGoals()
    {
        Console.WriteLine("what is the file name you would like to save to: ");
    string fileName = Console.ReadLine();
    List<string> lines = new List<string>();
    lines.Add(_score.ToString());
    foreach(BaseGoal goal in _goals)
        {
           lines.Add(goal.GetConsoleString());
        }
        File.WriteAllLines(fileName, lines);
    }
    public void recordEvent()
    {

        Console.WriteLine("The Goals Are:");
        displayGoals();
        Console.WriteLine("Which goal did you want to acompish: ");
        int choice = int.Parse(Console.ReadLine());

        int index = choice - 1;
        BaseGoal chosenGoal = _goals[index];//chosen goes back to base
        int pointsEarned = chosenGoal.RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"You have earned {pointsEarned} points");
        Console.WriteLine($"You have {_score} total points");

        if (index < 0 || index >= _goals.Count)// if the user choses something out of the range
        {
            Console.WriteLine("invalid choice");
            return;
        }
    }
}