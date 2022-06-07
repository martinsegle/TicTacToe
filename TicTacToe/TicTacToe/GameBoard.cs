

namespace TicTacToe
{
    public class GameBoard
    {
        public static void Board(char[,] board)
        {
            Console.WriteLine(" | 0 | 1 | 2 |");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        public static class CheckWin
        {
            public static string Get(int number)
            {
                return "TestOK";
            }
        }
    }
}

//        // GameBoard metode kas zīmē lauku
//        public static string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", };

//        public static void Board()
//        {

//            Console.WriteLine("     |     |      ");
//            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
//            Console.WriteLine("_____|_____|_____ ");
//            Console.WriteLine("     |     |      ");
//            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
//            Console.WriteLine("_____|_____|_____ ");
//            Console.WriteLine("     |     |      ");
//            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
//            Console.WriteLine("     |     |      ");
//        }
//    }
//}

