namespace Shapes.Tests;

public class ShapesAreaCalculationTests
{
    [Fact]
    public void CircleAreaMustBeCalculatedWithHighAccuracy()
    {
        var radiusInMeters = 5;
        var shape = new Circle(radiusInMeters);
        Assert.Equal(78.539816339744830961566084581988, shape.GetShapeArea(), 10);
    }

    [Fact]
    public void TriangleAreaMustBeCalculatedWithHighAccuracy()
    {
        var shape = new Triangle(10, 10, 10);
        Assert.Equal(43.30127018922193, shape.GetShapeArea(), 10);
    }

    [Fact]
    public void SystemThrowsExceptionIfTriangleCanNotExist()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
    }

    [Theory]
    [InlineData(10, 10, 10, false)]
    [InlineData(3, 4, 5, true)]
    public void TriangleIsRightByPyThagoreanTheorem(double a, double b, double c, bool isTriangleRight)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(isTriangleRight, triangle.IsTriangleRight);
    }
}