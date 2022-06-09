
using System;
using TicTacToe;

namespace TicTacToe
{
    
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            string appName = Wellcome.ApplicationName;
            Console.WriteLine($"Wellcom to {appName}");
            Console.WriteLine();

            Console.WriteLine("First player's name is?");
            string name1 = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(name1))
            {
                Console.WriteLine("You did not enter your name, please try again");
                name1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name1))
                {
                    Console.WriteLine("You will be a Player 'X'");
                }
                else
                {
                    Console.WriteLine($"Player {name1} play with 'X'");
                }
            }
            Console.WriteLine();

            Person player1 = new Person($"Player {name1} play with 'X'");

            Console.WriteLine();

            Console.WriteLine("Second player's name is?");
            string name2 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name2))
            {
                Console.WriteLine("You did not enter your name, please try again");
                name2 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name2))
                {
                    Console.WriteLine("You will be a Player 'O'");
                }
                else
                {
                    Console.WriteLine($"Player {name2} play with 'O'");
                }
            }

            Person player2 = new Person($"Player {name2} play with 'O'");

            char player = 'X';
            string playerName = player1.Name;


            // char[,] board = new char[3, 3]; //app izveido board - dēli
            // Initialize.Game(board); // sakārto dēli ar atstarpēm
            int movesPlayed = 0; // ja ir DRAW neveiksme, neviens nav uzvarējis
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', };

            while (true)
            {
                Console.Clear();
                GameBoard.Board(arr);

                //Console.Write($"Please enter row: {playerName} ");
                // ŠEIT PRASA, LAI SPĒLĒTĀJS SĀK IZVĒLĒTIES SKAITLI
                Console.Write($" {playerName} ");
                //int row = Convert.ToInt32(Console.ReadLine());
                int cell = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Please enter col: ");
                //int col = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("row: " + row + " col: " + col);
                Console.WriteLine("With a Number: " + cell);

                //board[row, col] = player;
                arr[cell - 1] = player;

                //check if we won
                //Pirmā līnija
                if (player == arr[0] && player == arr[1] && player == arr[2])
                {
                    Console.WriteLine(player + "has won the game!");
                    //Console.ReadKey() - NOMAINĀM uz šo gameEnd = true;
                    //gameEnd = true; ŠO NOMAINĀM UZ break;
                    break;
                }
                //Otrā līnija
                if (player == arr[3] && player == arr[4] && player == arr[5])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //trešā līnija
                if (player == arr[6] && player == arr[7] && player == arr[8])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //Pirmā kolona
                if (player == arr[0] && player == arr[3] && player == arr[6])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //otrā kolona
                if (player == arr[1] && player == arr[4] && player == arr[7])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //trešā kolona
                if (player == arr[2] && player == arr[5] && player == arr[8])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //diognāles
                if (player == arr[0] && player == arr[4] && player == arr[8])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                //diognāles
                if (player == arr[2] && player == arr[4] && player == arr[6])
                {
                    Console.WriteLine(player + "has won the game!");
                    break;
                }
                // pēc katra riņķa čeko vai nav DRAW, ja ir DRAW, tad neviens nav uzvarējis
                movesPlayed = movesPlayed + 1;

                if (movesPlayed == 9) // ja ir bijuši 9 riņķi un ja nav atrasts vinētājs, tad ir GAME OVER
                {
                    Console.WriteLine("Game Over (You have selected numbers 9 times)");
                    break; // bez brake nerādīs Game Over
                }

                // Celebration For Winner.
                // Clear the screen
                // Print the Board
                // Mention Who Won or If it was Draw

                player = Player.ChangeTurn(player);
                playerName = player2.Name;
            }
        }
    }
}