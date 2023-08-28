namespace MindboxTaskLibrary.Shapes;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    public bool IsRectangled => SideA * SideA + SideB * SideB == SideC * SideC;

    public Triangle(double side1, double side2, double side3, bool round = Config.Round, int precision = Config.Precision)
    {
        double[] sides = { side1, side2, side3 };
        for (int i = 0; i < sides.Length; i++)
        {
            sides[i] = Precision.ApplyPrecision(sides[i], round, precision);
            Validator.SideValidator(sides[i]);
        }
        Validator.TriangleValidator(sides);
        Array.Sort(sides);
        SideA = sides[0];
        SideB = sides[1];
        SideC = sides[2];

    }
    //Формула площади для прямоугольного треугольника
    double RectangledAreaFormula() => SideA * SideB / 2;
    //Общая формула площади треугольника
    double AreaFormula()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    //На основе того, является ли треугольник прямоугольным или нет, для вычисления площади выбирается соответствующая формула
    public double Area(bool round = Config.Round, int precision = Config.Precision) =>
        IsRectangled ? Precision.ApplyPrecision(RectangledAreaFormula(), round, precision) : Precision.ApplyPrecision(AreaFormula(), round, precision);
}
