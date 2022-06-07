

namespace TicTacToe
{
    public static class Initialize
    {
        public static void Game(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }
        public static string Get(int numbers)
        {
            return "";
        }
    }
}
