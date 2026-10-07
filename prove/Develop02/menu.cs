using System.Net;
using System.Runtime.InteropServices;

class Menu
{
    public int ProcessMenu()
    {
        int response = 0;

        while (response <= 1 || response >= 5 )
        {
            Console.WriteLine("Welcome to the journaling program!");
            Console.WriteLine("Create, Display, Save, and Read Journal Entries");
            Console.WriteLine("1. create new entry");
            Console.WriteLine("2. display journal entry");
            Console.WriteLine("3. save journal to file");
            Console.WriteLine("4. read journal from file");
            Console.WriteLine("5. quit");
            Console.Write("> ");

            response = int.Parse(Console.ReadLine());
            
        }
        return response;
    }
}//find and print smallest number on list the find and print largest number on predefined list, but call it into a function. part one meeds to loop until it finds it and the list is a double
