namespace MindboxTaskLibraryTest;

public class PrecisionTest
{
    [Fact]
    public void DefaultPrecision()
    {
        var result = 10.123456789;

        var actual = Precision.ApplyPrecision(result);

        Assert.Equal(10.123, actual);
    }
    [Fact]
    public void MaxPrecision()
    {
        var result = 10.123456789;

        var actual = Precision.ApplyPrecision(result, false);

        Assert.Equal(10.123456789, actual);
    }
    [Fact]
    public void CustomPrecision()
    {
        var result = 10.123456789;

        var actual = Precision.ApplyPrecision(result, true, 5);

        Assert.Equal(10.12346, actual);
    }
    [Fact]
    public void CustomPrecisionMaxRound()
    {
        var result = 10.123456789;

        var actual = Precision.ApplyPrecision(result, true, 0);

        Assert.Equal(10, actual);
    }
}
