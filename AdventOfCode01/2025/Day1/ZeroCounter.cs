namespace AdventOfCode01;

public class ZeroCounter
{
    public int AmountOfZeroes { get; set; } = 0;

    public void ResetZeroes() =>
        AmountOfZeroes = 0;
    public string GetZeroes() =>
        AmountOfZeroes.ToString();
}
