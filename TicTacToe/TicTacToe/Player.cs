
namespace TicTacToe
{
    public static class Configuration
    {
        public static readonly string ApplicationName = "TicTacToe #desuspēle";
        public static readonly string Grid1 = "        |        |        ";
        public static readonly string Grid2 = "        |        |        ";
        public static readonly string Grid3 = "        |        |        ";
        public static readonly string Grid4 = "--------------------------";
        public static readonly string Grid5 = "        |        |        ";
        public static readonly string Grid6 = "        |        |        ";
        public static readonly string Grid7 = "        |        |        ";
        public static readonly string Grid8 = "--------------------------";
        public static readonly string Grid9 = "        |        |        ";
        public static readonly string Grid10 = "        |        |        ";
        public static readonly string Grid11 = "        |        |        ";
    }
}
public class Player
{
    public Player(string name1)
    {
        Name = name1;
        Console.WriteLine($"Spēlētājs Nr.1 {name1}");
    }
    public string Name { get; }

    public class Player2
    {
        public Player2(string name2)
        {
            Name = name2;
            Console.WriteLine($"Spēlētājs Nr.2 {name2}");
        }
        public string Name { get; }
    }
}

