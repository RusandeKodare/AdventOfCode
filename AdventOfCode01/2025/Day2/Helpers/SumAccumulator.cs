namespace AdventOfCode01;

public class SumAccumulator
{
    private long sumOfAllInvalidIds;
    public long SumFromListOfInt(IEnumerable<long> collection)
    {
        foreach (var invalidId in collection)
        {
            sumOfAllInvalidIds = sumOfAllInvalidIds + invalidId;
        }
        return sumOfAllInvalidIds;
    }
}
