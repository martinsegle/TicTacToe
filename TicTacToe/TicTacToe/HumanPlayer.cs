

namespace TicTacToe
{
    public class HumanPlayer : BasePlayer
    {
        public void Player()
        {
            Console.WriteLine($"SPĒLĒS CILVĒKS AR CILVĒKU");

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
                Console.WriteLine("IEVADI MUMS SIMBOLU");
                userText = Console.ReadLine();
            }
            Simbol = userText;
        }

        public override int MakeMove()
        {
            bool couldParse;
            int number;
            do
            {
                Console.Write($"{Name} LŪDZU izvēlēs brīvo skaitli   ");
                string userInput = Console.ReadLine();
                couldParse = int.TryParse(userInput, out number);
            } while (!couldParse);
            return number;
        }


    }
}
