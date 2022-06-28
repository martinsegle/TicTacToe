
namespace TicTacToe
{
    public class ComputerPlayer : BasePlayer
    {
        public void ComputerTurn()
        {

        }
        public void Computer()
        {
            Console.WriteLine($"COMPUTER will play with HUMAN");

        }
        public override int MakeMove(char[] gameArray)
        {
            int computerNumber;

            do
            {
                Random random = new Random();
                computerNumber = random.Next(1, 10);
            }
            while (IsNumberAlreadyUse(gameArray, computerNumber));
            Console.WriteLine($"COMPUTER choice {computerNumber} press ENTER to continue");
            Console.ReadKey();

            return computerNumber;
            }
        }
    }


