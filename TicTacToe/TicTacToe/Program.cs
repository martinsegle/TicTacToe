
using System;

namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char player = 'X';

            char[,] board = new char[3, 3]; //app izveido board - dēli
            Initialize.Game(board); // sakārto dēli ar atstarpēm
            int movesPlayed = 0; // ja ir DRAW neveiksme, neviens nav uzvarējis

            while (true)
            {
                Console.Clear();
                GameBoard.Board(board);

                Console.Write("Please enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter col: ");
                int col = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("row: " + row + " col: " + col);

                board[row, col] = player;

                //check if we won
                //Pirmā līnija
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    //Console.ReadKey() - NOMAINĀM uz šo gameEnd = true;
                    //gameEnd = true; ŠO NOMAINĀM UZ break;
                    break;
                }
                //Otrā līnija
                if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //trešā līnija
                if (player == board[2, 0] && player == board[1, 0] && player == board[2, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //Pirmā kolona
                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //otrā kolona
                if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //trešā kolona
                if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //diognāles
                if (player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //diognāles
                if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                // pēc katra riņķa čeko vai nav DRAW, ja ir DRAW, tad neviens nav uzvarējis
                movesPlayed = movesPlayed + 1;

                if (movesPlayed == 9) // ja ir bijuši 9 riņķi un ja nav atrasts vinētājs, tad ir GAME OVER
                {
                    Console.WriteLine("DRAW");
                    break; // bez brake nerādīs DRAW
                }

                // Celebration For Winner.
                // Clear the screen
                // Print the Board
                // Mention Who Won or If it was Draw

                player = Player.ChangeTurn(player);
            }
        }
    }
}