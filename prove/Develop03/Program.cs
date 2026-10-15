using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction pt1 = new Fraction();

        Console.WriteLine(pt1.FractionString());
        Console.WriteLine(pt1.Decimalval());
        Fraction pt2 = new Fraction(5);

        Console.WriteLine(pt2.FractionString());
        Console.WriteLine(pt2.Decimalval());
        Fraction pt3 = new Fraction(3, 4);

        Console.WriteLine(pt3.FractionString());
        Console.WriteLine(pt3.Decimalval());
        Fraction pt4 = new Fraction(1, 3);

        Console.WriteLine(pt4.FractionString());
        Console.WriteLine(pt4.Decimalval());

        Random number = new Random();
        Fraction pt5 = new Fraction();
        for (int i = 0; i < 5; i++)
        {
            int topvalue = number.Next(1, 11);
            int bottomvalue = number.Next(1, 11);
            pt5.setTop(topvalue);
            pt5.Bottom(bottomvalue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {pt5.FractionString()}");
            Console.WriteLine($" Number: {pt5.Decimalval()}");

        }
        
    }


}