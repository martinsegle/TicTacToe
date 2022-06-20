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
        public static string ChangeName(string human, string human2, string currentPlayer)
        {
            if (currentPlayer == human)
            {
                return human2;
            }
            else
            {
                return human;
            }
        }


    }
}




