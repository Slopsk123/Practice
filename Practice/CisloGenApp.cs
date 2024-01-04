
namespace Practice;

internal class CisloGenApp
{
    public void Run()
    {
        Console.WriteLine(TextLength("jak se mas"));
    }
    public int Gen()
    {
        Random rnd = new Random();
        return rnd.Next(100000000, 1000000000);
    }

    public int ReturnBiggest(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
    public int TextLength(string x)
    {
        return RemoveWhiteSpaces(x).Length;
    }
    public string RemoveWhiteSpaces(string x)
    {
        return x.Replace(" ", "");
    }
}

    

