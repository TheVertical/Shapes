namespace Shapes;

public interface IShape
{
    public double GetShapeArea();
}

public interface ICircle : IShape
{
    public double Radius { get; }
}

public sealed class Circle : ICircle
{
    public Circle(double radiusInMeters)
    {
        Radius = radiusInMeters;
    }

    public double Radius { get; }

    public double GetShapeArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public interface ITriangle : IShape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }
}

public sealed class Triangle : ITriangle
{
    public Triangle(double a, double b, double c)
    {
        if (!(a + b >= c && b + c >= a && a + c >= b))
        {
            throw new ArgumentException("Triangle can not exist.");
        }

        A = a;
        B = b;
        C = c;
    }

    public double GetShapeArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsTriangleRight => Math.Abs(Math.Pow(C, 2) - (Math.Pow(A, 2) + Math.Pow(B, 2))) < 0.0000000001;

    public double A { get; }
    public double B { get; }
    public double C { get; }
}