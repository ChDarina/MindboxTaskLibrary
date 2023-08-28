namespace MindboxTaskLibrary.Utilities;

internal static class Precision
{
    internal static double ApplyPrecision(double result, bool round = Config.Round, int precision = Config.Precision)
    {
        Validator.PrecisionValidator(precision);
        return round ? Math.Round(result, precision) : result;
    }
}
