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

            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "what did you have for breakfast?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rand = new Random();
        int index = rand.Next(prompts.Count);

        _prompt = prompts[index];

        Console.Write($"{_prompt}");
        _response = Console.ReadLine();
    }


}