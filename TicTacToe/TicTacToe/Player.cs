namespace TicTacToe
{

    public class Player
    {
        public static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
        public static string ChangeName(string player1, string player2, string currentPlayer)
        {
            if (currentPlayer == player1)
            {
                return player2;
            }
            else
            {
                return player1;
            }
        }
    }
}




