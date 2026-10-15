class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 1.0;
    }

    public Circle(double radius)
    {
        _radius = radius; // same as setting radius
    }
    public double GetArea() //private gets security to limit how its changed and where it can be applied
    //constructor is public, same as class name
    {
        double area;
        area = _radius * _radius * 3.14159;
        return area;

    }

    public double Getcir()
    {
        return 2 * 3.14 * _radius;
    }

    public void setradius(double radius)
    {
        if (radius < 0.0)
        {
            _radius = 1.0;
            Console.WriteLine("Error");
        }
        else
        {
            _radius = radius;
        }
    }
}

