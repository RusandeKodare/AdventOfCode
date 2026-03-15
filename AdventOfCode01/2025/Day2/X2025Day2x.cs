namespace AdventOfCode01;
public class X2025Day2x(IParser parser, string input)
{
    private List<string> splittedInputSingle = [];
    private List<long> invalidIds = [];
    private long sumOfAllInvalidIds;

    public long ReturnSumOfInvalidIds()
    {
        splittedInputSingle = parser.ReturnListFromString(input);
        return ProcessRanges();
    }
        
    private long ProcessRanges()
    {
        long startDigit;
        long endDigit;

        for (int i = 0; i < splittedInputSingle.Count; i += 2)
        {
            var secondPlaceToCompare = i + 1;

            startDigit = long.Parse(splittedInputSingle[i]);
            endDigit = long.Parse(splittedInputSingle[secondPlaceToCompare]);
            _ = ProcessRangeForInvalidIds(startDigit, endDigit);
        }

        return SumInvalidIds();
    }

    private long SumInvalidIds()
    {
        foreach (var invalidId in invalidIds)
        {
            sumOfAllInvalidIds = sumOfAllInvalidIds + invalidId;
        }
        return sumOfAllInvalidIds;
    }

    private long ProcessRangeForInvalidIds(long startDigit, long endDigit)
    {
        while (startDigit <= endDigit)
        {
            var digitToString = startDigit.ToString();
            FindMatchesInString(startDigit, digitToString);
            startDigit++;
        }

        return startDigit;
    }

    private void FindMatchesInString(long startDigit, string digitToString)
    {
        var timesToTry = digitToString.Length;

        var match = false;

        while (timesToTry > 1 && !match)
        {
            List<string> listOfDividedNumbers = [];

            if (digitToString.Length % timesToTry == 0)
            {
                match = CheckForRepeatingSegments(startDigit, digitToString, timesToTry, match, listOfDividedNumbers);
            }

            timesToTry--;
        }

        //From part 1, not needed for part 2
        //if (digitToString.Length % 2 == 0)
        //{
        //    var half = digitToString.Length / 2;
        //    var firstHalf = digitToString.Substring(0, half);
        //    var otherHalf = digitToString.Substring(half);

        //    if (firstHalf == otherHalf)
        //        invalidIds.Add(startDigit);
        //}
    }

    private bool CheckForRepeatingSegments(long startDigit, string digitToString, int timesToTry, bool match, List<string> listOfDividedNumbers)
    {
        var divider = digitToString.Length / timesToTry;

        for (int i = 0; i < timesToTry; i++)
        {
            listOfDividedNumbers.Add(digitToString.Substring(i * divider, divider));
        }

        for (int i = 0; i < listOfDividedNumbers.Count() - 1; i++)
        {

            if (listOfDividedNumbers[i] != listOfDividedNumbers[i + 1])
            {
                match = false;
                break;
            }
            else
                match = true;

        }
        if (match)
            invalidIds.Add(startDigit);
        return match;
    }
}
