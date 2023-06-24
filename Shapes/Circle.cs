namespace Shapes;

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