using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;

    }
    public Fraction(int top, int Bottom)
    {
        _top = top;
        _bottom = Bottom;
    }
    public void Bottom(int bottom)
    {if (bottom != 0)
        {
            _bottom = bottom;

        }
        else
        {
            _bottom = 1;
        }   
    }
    public void setTop(int top)
    {
        _top = top;
    }
    public int getTop()
    {
        return _top;
    }
    public int getBottom()
    {
        return _bottom;
    }
    public string FractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double Decimalval()
    {
        return (double)_top / (double)_bottom;
    }
}