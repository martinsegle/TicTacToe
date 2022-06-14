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

    }
}




