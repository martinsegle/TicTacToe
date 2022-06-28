

namespace TicTacToe
{
    public class GameBoard
    {

        public static void Board(char[] arr)
        {
            string appName = Wellcome.ApplicationName;
            Console.WriteLine($"Let's Play {appName}");
            Console.WriteLine();

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      ");

            Console.WriteLine();
            Console.WriteLine("Choose Your number");
            Console.WriteLine();
        }
    }

    // RANDOM KODS LAI IZVEIDOTU CheckWinTest
    public class CheckWin
    {
        public static string Get(int number)
        {
            return "TestOK";
        }
    }
}




