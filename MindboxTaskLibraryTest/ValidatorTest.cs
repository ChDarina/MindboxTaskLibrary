namespace MindboxTaskLibraryTest;

public class ValidatorTest
{
    [Fact]
    public void SideIsValid()
    {
        var side = 2;

        var condition = Validator.SideValidator(side);

        Assert.True(condition);
    }
    [Fact]
    public void SideIsInvalid()
    {
        var side = -2;

        Action act = () => Validator.SideValidator(side);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal("Side can not be assigned to a value less than or equal to 0", exception.Message);
    }
    [Fact]
    public void PrecisionIsValid()
    {
        var precision = 2;

        var condition = Validator.PrecisionValidator(precision);

        Assert.True(condition);
    }
    [Theory]
    [InlineData(-2, "Precision can only be assigned to a value between 0 and 15, inclusive")]
    [InlineData(16, "Precision can only be assigned to a value between 0 and 15, inclusive")]
    public void PrecisionIsInvalid(int precision, string expected)
    {
        Action act = () => Validator.PrecisionValidator(precision);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal(expected, exception.Message);
    }
    [Fact]
    public void TriangleIsValid()
    {
        double[] sides = { 2, 3, 4 };

        var condition = Validator.TriangleValidator(sides);

        Assert.True(condition);
    }
    [Fact]
    public void TriangleIsInvalid()
    {
        double[] sides = { 2, 3, 999 };

        Action act = () => Validator.TriangleValidator(sides);
        ArgumentException exception = Assert.Throws<ArgumentException>(act);

        Assert.Equal("Triangle with such sides does not exist", exception.Message);
    }
}
