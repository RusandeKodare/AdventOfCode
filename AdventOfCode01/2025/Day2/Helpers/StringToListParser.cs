namespace AdventOfCode01;

public class StringToListParser: IParser
{
    private string[] splittedInputPairs = [];
    private List<string> splittedInputSingle = [];
    public List<string> ReturnListFromString(string input)
    {
        splittedInputPairs = input.Split(",");

        foreach (var thing in splittedInputPairs)
        {
            var splitted = thing.Split("-");
            splittedInputSingle.AddRange(splitted);
        }

        return splittedInputSingle;
    }

}
