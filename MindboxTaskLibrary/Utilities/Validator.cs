namespace MindboxTaskLibrary.Utilities;

internal static class Validator
{
    internal static bool PrecisionValidator(int precision) =>
        precision >= 0 && precision < 16  ? true : throw new ArgumentException("Precision can only be assigned to a value between 0 and 15, inclusive");
    internal static bool SideValidator(double side) =>
       side > 0 ? true : throw new ArgumentException("Side can not be assigned to a value less than or equal to 0");
    internal static bool TriangleValidator(double[] sides) =>
         sides[0] + sides[1] > sides[2] && sides[1] + sides[2] > sides[0] && sides[0] + sides[2] > sides[1]
            ? true : throw new ArgumentException("Triangle with such sides does not exist");
}
