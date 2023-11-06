using System.Drawing;
using Xunit;
using Lab4;

public class ShapeTests
{
    [Fact]
    public void PointInitializationTest()
    {
        var point = new Lab4.Point(0, 0);
        Assert.Equal(0, point.X);
        Assert.Equal(0, point.Y);
    }
    [Fact]
    public void PointMoveTest()
    {
        var point = new Lab4.Point(0, 0);
        point.Move(5, 5);
        Assert.Equal(5, point.X);
        Assert.Equal(5, point.Y);
    }

    [Fact]
    public void SquareMoveTest()
    {
        var square = new Square(new Lab4.Point(0, 0), 10);
        square.Move(5, 5);
        Assert.Equal(5, square.Center.X);
        Assert.Equal(5, square.Center.Y);
    }
    [Fact]
    public void RhombusMoveTest()
    {
        var rhombus = new Rhombus(new Lab4.Point(0, 0), 10, 5);
        rhombus.Move(5, 5);
        Assert.Equal(5, rhombus.Center.X);
        Assert.Equal(5, rhombus.Center.Y);
    }
    [Fact]
    public void EquilateralTriangleMoveTest()
    {
        var triangle = new EquilateralTriangle(new Lab4.Point(0, 0), 10);
        triangle.Move(5, 5);
        Assert.Equal(5, triangle.Center.X);
        Assert.Equal(5, triangle.Center.Y);
    }
}

