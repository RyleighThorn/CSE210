using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernum = -1;
        do
        {
        Console.WriteLine("Enter list of numbers and write 0 to quit");
        Console.Write("Enter number: ");

        string userchoice = Console.ReadLine();
        usernum = int.Parse(userchoice);

        if (usernum != 0) // if there is something then add it together
            {
                numbers.Add(usernum);
            }
            int sum = 0;
            foreach (int number in numbers) // for each veriable in the list for numbers
            {
                sum += number; // sum += is adding number to numbers list as a whole
            }
            Console.WriteLine($"{sum}"); //does it need to be sum? yes it will not process otherwise

            float average = ((float)sum)/numbers.Count; //float because fo the needed decimals
            Console.WriteLine($"the average is {average}");

            int max = numbers.Max();
            Console.WriteLine("The largest number is: " + max);
        } while (usernum != 0);
        
        
        
        /*string onenumber = "";
        string twonumber = "";
        string threenumber = "";
        string fournumber = "";
        string fivenumber = "";

        List<double> numbers = new List<double>();
        numbers.Add(5);
        Console.WriteLine("Enter list of numbers");
        Console.Write("Enter number: ");
        onenumber = Console.ReadLine();
        int one = int.Parse(onenumber);

        Console.Write("Enter number: ");
        twonumber = Console.ReadLine();
        int two = int.Parse(twonumber);

        Console.Write("Enter number: ");
        threenumber = Console.ReadLine();
        int three = int.Parse(threenumber);

        Console.Write("Enter number: ");
        fournumber = Console.ReadLine();
        int four = int.Parse(fournumber);

        Console.Write("Enter number: ");
        fivenumber = Console.ReadLine();
        int five = int.Parse(fivenumber);

        numbers.Add(one);
        numbers.Add(two);
        numbers.Add(three);
        numbers.Add(four);
        numbers.Add(five);

        Console.WriteLine($"the sum is {numbers}");
        var dividednum = numbers.Select (n => n / 5).ToList();
        Console.WriteLine(numbers);

        double max = numbers.Max();
        Console.WriteLine("The largest number is: " + max);

        /*numbers[i] /= 5;
        Console.WriteLine(numbers);*/
    }
}