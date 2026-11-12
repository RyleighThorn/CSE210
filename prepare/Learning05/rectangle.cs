using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width)
    : base (color)
    {_length=length;
    _width=width;}
    public override double getArea()
    {
        return _length * _width;
    }
}