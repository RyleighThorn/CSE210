using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius)
    : base (color)
    {_radius=radius;}
    public override double getArea()
    {
        return Math.PI * (_radius * 2);
    }
}