namespace OOP;

public class Triangle : IShape, IComparable<Triangle>
{
    private readonly double _height;
    private readonly double _side;

    public Triangle(double height, double side)
    {
        _height = height;
        _side = side;
    }


    public double Area()
    {
        return _side * _height / 2;
    }

    public double Perimeter()
    {
        return 0;
    }

    public int CompareTo(Triangle? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var heightComparison = _height.CompareTo(other._height);
        if (heightComparison != 0) return heightComparison;
        return _side.CompareTo(other._side);
    }
}