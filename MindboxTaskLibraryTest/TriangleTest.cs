namespace MindboxTaskLibraryTest;

public class TriangleTest
{
    [Fact]
    public void SidesAreValid()
    {
        var triangle = new Triangle(2, 4, 5);

        Assert.Equal(2, triangle.SideA);
        Assert.Equal(4, triangle.SideB);
        Assert.Equal(5, triangle.SideC);
    }

    [Fact]
    public void IsRectangled()
    {
        var triangle = new Triangle(3, 4, 5);

        var condition = triangle.IsRectangled;

        Assert.True(condition);
    }
    [Fact]
    public void IsNotRectangled()
    {
        var triangle = new Triangle(2, 4, 5);

        var condition = triangle.IsRectangled;

        Assert.False(condition);
    }
    [Fact]
    public void AreaIsCorrect()
    {
        var triangle = new Triangle(2, 4, 5);

        var actual = triangle.Area();

        Assert.Equal(3.8, actual);
    }
    [Fact]
    public void AreaIsCorrectViaInterface()
    {
        var triangle = new Triangle(2, 4, 5);

        var actual = Shape.CalculateArea(triangle);

        Assert.Equal(3.8, actual);
    }

    [Fact]
    public void AreaIsCorrectRectangled()
    {
        var triangle = new Triangle(3, 4, 5);

        var actual = triangle.Area();

        Assert.Equal(6, actual);
    }
    [Fact]
    public void AreaIsCorrectViaInterfaceRectangled()
    {
        var triangle = new Triangle(3, 4, 5);

        var actual = Shape.CalculateArea(triangle);

        Assert.Equal(6, actual);
    }
}
