

namespace TicTacToe
{
    public abstract class BasePlayer
    {
        public static readonly string ApplicationName = "TicTacToe game";

        public string Name { get; set; }

        public string Simbol { get; set; }

        public string Choise { get; set; }

        public void ShowPlayerInfo()
        {
            Console.WriteLine($"Player {Name} play with {Simbol}");
        }
        public abstract int MakeMove();
    }
}
