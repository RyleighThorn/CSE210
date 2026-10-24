using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        Console.WriteLine("1. Continue");
        Console.WriteLine("2. Quit");

        Word myWord = new Word("bubba"); //hardcoding the word in
        myWord.Display();
        myWord.IsHidden();
        Console.WriteLine();
        myWord.Display();

        Scripture myScripture = new Scripture("Moses", 1, 39, "Behold this is my word and my golary to bring to pass the immortality and eternal life of man.");
        Console.Clear();
        myScripture.ShowScripture();

        while(loop){//make the loop so it keeps hiding words until you press q for quit
        Console.WriteLine("");
        Console.WriteLine("1. Continue");
        Console.WriteLine("2. Quit");
        Console.WriteLine("Pick an option, enter or type quit:");
        string input = Console.ReadLine().ToLower();
        if (input == "")
            {
                Console.Clear();
                myScripture.HideRandom(3);
                myScripture.ShowScripture();
                if (myScripture.AllAreHidden())
                {
                    Console.WriteLine("");
                    Console.WriteLine("you got all the words!");
                    loop = false;
                }
                
            }else if (input == "quit")
            {
                loop = false;
            }
            else
            {
                Console.WriteLine("that is not a correct reply");
                
            }
    }
}
}