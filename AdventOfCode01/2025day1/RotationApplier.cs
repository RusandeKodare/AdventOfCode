using AdventOfCode01.Interfaces;

namespace AdventOfCode01;

public class RotationApplier(IUI ui, ZeroCounter zeroCounter, bool countAllZeroes = false)
{
    public void ApplyRotation(ref int currentPosition, string number)
    {
        if (number.StartsWith("R"))
        {
            ApplyRightRotation(ref currentPosition, number);
        }
        else if (number.StartsWith("L"))
        {
            ApplyLeftRotation(ref currentPosition, number);
        }
        else
        {
            ui.Write("No R or L found in this position.");
        }

        if (currentPosition is 0 && countAllZeroes is false)
            zeroCounter.AmountOfZeroes++;
    }

    private void ApplyLeftRotation(ref int currentPosition, string number)
    {
        int convertedDigit = RotationParser.ParseRotation(number);

        if (currentPosition - convertedDigit < 0)
        {
            for (int i = 0; i < convertedDigit; i++)
            {
                if (currentPosition == 0)
                {
                    currentPosition = 99;
                }
                else
                {
                    currentPosition--;
                    if (countAllZeroes is true && currentPosition is 0)
                        zeroCounter.AmountOfZeroes++;
                }
            }
        }
        else
        {
            currentPosition -= convertedDigit;
            if (currentPosition == 0 && countAllZeroes is true)
                zeroCounter.AmountOfZeroes++;
        }

    }

    private void ApplyRightRotation(ref int currentPosition, string number)
    {
        int convertedDigit = RotationParser.ParseRotation(number);

        if (currentPosition + convertedDigit > 99)
        {
            for (int i = 0; i < convertedDigit; i++)
            {
                if (currentPosition == 99)
                {
                    currentPosition = 0;
                    if (countAllZeroes is true)
                        zeroCounter.AmountOfZeroes++;
                }
                else
                {
                    currentPosition++;
                }
            }
        }
        else
        {
            currentPosition += convertedDigit;
            if (currentPosition == 0 && countAllZeroes is true)
                zeroCounter.AmountOfZeroes++;
        }
    }
}
