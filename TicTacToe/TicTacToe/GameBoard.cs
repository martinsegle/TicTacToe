

namespace TicTacToe
{
    public class GameBoard
    {

        // GameBoard metode kas zīmē lauku
        public static string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", };

        public static void Board()
        {

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      ");
        }


        public static class CheckWin
        {
            public static string Get(int number)
            {
                if (arr[1] == arr[2] && arr[2] == arr[3])
                {
                    return "";
                }
                return "";
            }
        }
    }
}

