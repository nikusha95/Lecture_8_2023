namespace OOP;

public class Rectangle : IShape
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public double Area()
    {
        return _length * _width;
    }

    public double Perimeter()
    {
        return 2 * (_length + _width);
    }
}