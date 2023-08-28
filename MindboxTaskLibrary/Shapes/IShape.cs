namespace MindboxTaskLibrary.Shapes;

public interface IShape
{
    public double Area(bool round = Config.Round, int precision = Config.Precision);
}
