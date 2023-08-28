namespace MindboxTaskLibrary.Shapes;

public class Circle : IShape
{
    public double Radius { get; }
    public Circle(double radius, bool round = Config.Round, int precision = Config.Precision)
    {
        radius = Precision.ApplyPrecision(radius, round, precision);
        Validator.SideValidator(radius);
        Radius = radius;
    }
    double AreaFormula() => Math.PI * Radius * Radius;

    public double Area(bool round = Config.Round, int precision = Config.Precision) => Precision.ApplyPrecision(AreaFormula(), round, precision);
}