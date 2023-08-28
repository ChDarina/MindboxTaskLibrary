namespace MindboxTaskLibraryTest;

public class CircleTest
{
    [Fact]
    public void RadiusIsValid()
    {
        var circle = new Circle(2);

        Assert.Equal(2, circle.Radius);
    }
    [Fact]
    public void AreaIsCorrect()
    {
        var circle = new Circle(2);

        var actual = circle.Area();

        Assert.Equal(12.566, actual);
    }
    [Fact]
    public void AreaIsCorrectViaInterface()
    {
        var circle = new Circle(2);

        var actual = Shape.CalculateArea(circle);

        Assert.Equal(12.566, actual);
    }
}