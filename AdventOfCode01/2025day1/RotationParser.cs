namespace AdventOfCode01;

public static class RotationParser
{
    public static int ParseRotation(string item)
    {
        var digitWeNeed = new string(item.Skip(1).ToArray());
        var convertedDigit = int.Parse(digitWeNeed);
        return convertedDigit;
    }
}
