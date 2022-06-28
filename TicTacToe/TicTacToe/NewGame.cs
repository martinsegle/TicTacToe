

namespace TicTacToe
{
    public class NewGame : Game
    {
        public void PlayGame(BasePlayer player1, BasePlayer player2)
        {
            HumanDesignation designation = HumanDesignation.First;
            char charValue = (char)designation;
            char player = charValue;
            string playerName = player1.Name;

            int movesPlayed = 0; // ja ir DRAW neveiksme, neviens nav uzvarējis

            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', };


            while (true)
            {
                Console.Clear();

                GameBoard.Board(arr);

                playerName = Player.ChangeName(player1.Name, player2.Name, playerName);

                int number;

                //ToString pateica, ka (char) ir teksts
                if (player.ToString().ToUpper() == player1.Simbol.ToUpper())
                {
                    number = player1.MakeMove(arr);
                }
                else
                {
                    number = player2.MakeMove(arr);
                }
                arr[number - 1] = player;
                //check if we won
                //Pirmā līnija
                if (player == arr[0] && player == arr[1] && player == arr[2])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    //Console.ReadKey() - NOMAINĀM uz šo gameEnd = true;
                    //gameEnd = true; ŠO NOMAINĀM UZ break;
                    break;
                }
                //Otrā līnija
                if (player == arr[3] && player == arr[4] && player == arr[5])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                //trešā līnija
                if (player == arr[6] && player == arr[7] && player == arr[8])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                //Pirmā kolona
                if (player == arr[0] && player == arr[3] && player == arr[6])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                //otrā kolona
                if (player == arr[1] && player == arr[4] && player == arr[7])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                //trešā kolona
                if (player == arr[2] && player == arr[5] && player == arr[8])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                //diognāles
                if (player == arr[0] && player == arr[4] && player == arr[8])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                //diognāles
                if (player == arr[2] && player == arr[4] && player == arr[6])
                {
                    Console.WriteLine($"{playerName} has won the game!");
                    break;
                }
                // pasaka ar kuru nr. viņš ir vinnējis
                Console.WriteLine("With a Number: " + number);

                // pēc katra riņķa čeko vai nav DRAW, ja ir DRAW, tad neviens nav uzvarējis
                movesPlayed = movesPlayed + 1;

                if (movesPlayed == 9) // ja ir bijuši 9 riņķi un ja nav atrasts vinētājs, tad ir GAME OVER
                {
                    Console.WriteLine("Game Over (You have selected numbers 9 times)");
                    break; // bez brake nerādīs Game Over
                }
                
                player = Player.ChangeTurn(player);
                playerName = player2.Name;
            }
        }

    }
}
