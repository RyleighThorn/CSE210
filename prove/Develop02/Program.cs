using System;
using System.Transactions;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int response = 0 ;
        JournalEntry newEntry = new JournalEntry();
        Journal myJournal = new Journal();

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                Console.WriteLine("Create");
                newEntry.CreateJournalEntry();
                myJournal.AddEntry(newEntry);
                    break;
                case 2:
                Console.WriteLine("display");
                newEntry.DisplayEntry();
                myJournal.showentries();
                    break;
                case 3:
                Console.WriteLine("save");

                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                myJournal.SaveJournalEntry(filename);
                    break;

                case 4:
                Console.WriteLine("write");

                Console.Write("Enter filename to load from: ");
                string loadFilename = Console.ReadLine();

                myJournal.loadfromfile(loadFilename);
                    break;
            }
        }
    }
}