namespace AdventOfCode01;

internal class Program
{
    static void Main(string[] args)
    {
        var ui = new UI.UI();
        var countAllZeroes = true;
        var zeroCounter = new ZeroCounter();
        var rotationApplier = new RotationApplier(ui, zeroCounter, countAllZeroes);

        var x2025Day1Part1x = new x2025Day1x(rotationApplier);

        x2025Day1Part1x.CalcuateAmountOfZeroes();

        ui.Write(zeroCounter.GetZeroes());
    }
}
