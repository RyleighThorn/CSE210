using System.Data;

class Program
{
  //public double _radius;
  static void Main()
    {
      int x = 10;

      Circle myCircle = new Circle();

      //myCircle.setradius(10); now we dont need this with the constructor in program, dont need to call

      double area = myCircle.GetArea();

      Console.WriteLine(area);
    }
};