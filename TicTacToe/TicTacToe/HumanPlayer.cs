

namespace TicTacToe
{
    public class HumanPlayer : BasePlayer
    {
        public void Player()
        {
            Console.WriteLine($"HUMAN will play with HUMAN");

        }
        public void AskName()
        {
            Console.WriteLine("Player's name is?");
            string playerName = Console.ReadLine();

            //šis būs cikls
            while (string.IsNullOrWhiteSpace(playerName))
            {
                Console.WriteLine("You did not enter your name, please try again");
                playerName = Console.ReadLine();
            }
            Name = playerName;
        }
        public void AskSimbol()
        {
            Console.WriteLine($" {Name} choice 'x' or 'o'");
            string userText = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userText) || (userText != "x" && userText != "o"))
            {
                Console.WriteLine("Enter simbol");
                userText = Console.ReadLine();
            }
            Simbol = userText;
        }

        public override int MakeMove(char[] gameArray)
        {
            bool couldParse;
            int number;
            do
            {
                Console.Write($"{Name} Please select a free number");
                string userInput = Console.ReadLine();
                couldParse = int.TryParse(userInput, out number);
            } while (!couldParse || IsNumberAlreadyUse(gameArray, number));
            return number;
        }


    }
}
