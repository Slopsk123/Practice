
namespace Practice;

internal class prac
{
    public void Run()
    {
        Random random = new Random();
        int randX = random.Next(0, 10);
        int randY = random.Next(0, 10);

        string X = GameX(randX, ToInt(Console.ReadLine()));
        string Y = GameY(randY, ToInt(Console.ReadLine()));

        while (X != "" && Y != "")
        {
          Console.WriteLine($"{X},{Y}"); 
          X = GameX(randX, ToInt(Console.ReadLine()));
          Y = GameY(randY, ToInt(Console.ReadLine()));
        }
        Console.WriteLine("Nasli jste poklad");

    }

    public string GameX(int x, int y)
    {
        if (x > y)
            return "vychod"; 
        else if (x < y)
            return "zapad";
        else
            return "";
    }

    public string GameY(int x, int y)
    {
        if (x > y)
            return "sever";
        else if (x < y)
            return "jih";
        else
            return "";
    }
    public void connect(string a)
    {
        Console.WriteLine($"propojuji se na {a}");
    }
    public int ToInt(string x)

    {

        if (int.TryParse(x, out int result))

        {

            return result;

        }

        else

        {

            return 0;

        }

    }

} 

