
using System;
using TicTacToe;


namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Spēlētājs Nr.1 Ievadi savu vārdu");
            string name1 = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(name1))
            {
                Console.WriteLine("Tu neievadīji savu vārdu, mēģini vēlreiz");
                name1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name1))
                {
                    Console.WriteLine("Jūs būsiet Spēlētājs Nr.1");
                }
                else
                {
                    Console.WriteLine($"Tavs vārds ir: {name1}");
                }
            }

            Person player1 = new Person(name1);



            Console.WriteLine("Spēlētājs Nr.2 Ievadi savu vārdu");
            string name2 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name2))
            {
                Console.WriteLine("Tu neievadīji savu vārdu, mēģini vēlreiz");
                name2 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name2))
                {
                    Console.WriteLine("Jūs būsiet Spēlētājs Nr.2");
                }
                else
                {
                    Console.WriteLine($"Tavs vārds ir: {name2}");
                }
            }

            Person player2 = new Person(name2);

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

                Console.Write($"Please enter row: {playerName} ");
                //int row = Convert.ToInt32(Console.ReadLine());
                int cell = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Please enter col: ");
                //int col = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("row: " + row + " col: " + col);
                Console.WriteLine("row: " + cell);

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
                    Console.WriteLine("DRAW");
                    break; // bez brake nerādīs DRAW
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