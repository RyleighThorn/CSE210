class JournalEntry
{
    //public DateTime currentDate = DateTime.Now;
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayEntry()
    {
        Console.Write($"{_date}, ");
        Console.WriteLine($"{_prompt}, ");
        Console.WriteLine($"{_response} ");
    }

    public void CreateJournalEntry()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
        List<string> prompts = new List<string>
        {
            "How was your day? ",
            "What was the highlight of your day? ",
            "What did you eat for breakfast? "
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Count);

        _prompt = prompts[index];

        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }


}