namespace AdventOfCode01;

public interface IUI
{
    public void Write(string output);
    public string Read();
}

public class UI : IUI
{
    public string Read() =>
        Console.ReadLine();
    
    public void Write(string output) =>
        Console.WriteLine(output);
    
}
