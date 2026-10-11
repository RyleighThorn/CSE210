using System.Net;
using System.Runtime.InteropServices;
using System.IO;

class Journal
{

public List<JournalEntry> _entries = new List<JournalEntry>();  

    public void AddEntry(JournalEntry newEntry) //add to the entrie file lis
    {
        _entries.Add(newEntry);
    }

    public void showentries() //show the entries you added for pt 4
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Got no entries.\n");
            return;
        }
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournalEntry(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
        Console.Write("test");
    }

    public void loadfromfile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                
                JournalEntry entry = new JournalEntry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                _entries.Add(entry);
            }
        }
        }

}