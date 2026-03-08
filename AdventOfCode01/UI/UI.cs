using AdventOfCode01.Interfaces;

namespace AdventOfCode01.UI;

public class UI : IUI
{
    public string Read() =>
        Console.ReadLine();
    
    public void Write(string output) =>
        Console.WriteLine(output);
    
}
