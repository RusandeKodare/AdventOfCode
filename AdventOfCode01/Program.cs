namespace AdventOfCode01;

internal class Program
{
    static void Main(string[] args)
    {
        var ui = new UI();
        var rotationApplier = new RotationApplier(ui);
        var twntyTwntyFive = new TwntyTwntyFiveDay1Part1(rotationApplier);

        var amountOfZeroes = twntyTwntyFive.CalcuateAmountOfZeroes().ToString();

        ui.Write(amountOfZeroes);
    }
}
