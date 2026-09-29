using System.Data;

class Program
{
  //public double _radius;
  static void Main()
    {
        Circle myCircle = new Circle();
        myCircle._radius = 10;
        double area = myCircle.GetArea();

        Console.WriteLine(area);
    }
};