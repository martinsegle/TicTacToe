

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
        public abstract int MakeMove(char[] gameArray);

        //Metode paņem masīvu ar elementiem un pārbauda, vai izvēlētājā ailē nav gadījumā X vai O
        protected bool IsNumberAlreadyUse(char[] gameArray, int playerNumber)
        {
            char valueInArray = gameArray[playerNumber - 1];
            if(valueInArray == 'x' || valueInArray == 'o')
            {
                return true;
            }

            return false;
        }
    }
}
