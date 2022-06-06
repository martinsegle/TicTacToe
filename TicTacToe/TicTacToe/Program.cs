using TicTacToe;



Console.WriteLine();
Console.WriteLine("============= Player Nr.1 =================");
Console.WriteLine();



Console.WriteLine("Spēlētājs Nr.1 Ievadi savu vārdu");
string name1 = Console.ReadLine();

if (string.IsNullOrWhiteSpace (name1))
{
    Console.WriteLine("Tu neievadīji savu vārdu, mēģini vēlreiz");
    name1 = Console.ReadLine();

    if (string.IsNullOrWhiteSpace (name1))
    {
        Console.WriteLine("Jūs būsiet Spēlētājs Nr.1");
    }
    else
    {
        Console.WriteLine($"Tavs vārds ir: {name1}");
    }
}

Player player1 = new Player(name1);


Console.WriteLine();
Console.WriteLine("============= Player Nr.2 =================");
Console.WriteLine();


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

Player player2 = new Player(name2);

//Jāprasa lietotājiem kādu lauku vēlas aizpildīt.
string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", };


Console.WriteLine($"Spēlētāj Nr.1 {name1} aizpildi izvēlēto lauku no 1-9");
Console.WriteLine($"Spēlētāj Nr.2 {name2} aizpildi izvēlēto lauku no 1-9");


GameBoard.Board();
GameBoard.Board();//šis sasien kopā GameBoard failu ar Program failu
GameBoard.CheckWin();




Console.WriteLine();
Console.WriteLine("============= TicTacToe VARIANTS NR.1 =================");
Console.WriteLine();


//namespace TicTacToe
//{
//    class Program
//    {
//        static int[] board = new int[9];
//        static void Main(string[] args)
//        {
//            //ŠO VAR SAĪSINĀT ar "for (int i = 0; i <9; i++) {board[i] = 0;} ZEMĀK KAS IR"
//            //board[0] = 0;
//            //board[1] = 0;
//            //board[2] = 0;
//            //board[3] = 0;
//            //board[4] = 0;
//            //board[5] = 0;
//            //board[6] = 0;
//            //board[7] = 0;
//            //board[8] = 0;
//            for (int i = 0; i < 9; i++)
//            {
//                board[i] = 0;
//            }

//            int userTurn = -1;  // jāiedod vērtība lai "while (board[userTurn] ! = 0)" nebūtu pasvītrots kā kļūda
//            int computerTurn = -1;

//            Random rand = new Random();

//            // izveidojot "private static int checkForWiner" šis "while(true)" mainās uz:
//            while (checkForWinner() == 0)
//            { // prasa call chec for winners

//                // dont allow the human to choose an already occupied square
//                while (userTurn == -1 || board[userTurn] != 0)
//                {
//                    Console.WriteLine("Please enter a number from 0 to 8");

//                    userTurn = int.Parse(Console.ReadLine());
//                    Console.WriteLine("You type" + userTurn);
//                }

//                board[userTurn] = 1;

//                // dont let the computer pick an invalid number
//                while (computerTurn == -1 || board[computerTurn] != 0)
//                {
//                    computerTurn = rand.Next(8);
//                    // board[computerTurn] = 2; // savādāk never ending story
//                    Console.WriteLine("Computer chooses " + computerTurn);
//                }

//                board[computerTurn] = 2;
//                printBoard();
//            }
//            // Kad savadīts "private static int chechForWinner()"
//            // tad arī izveidi šo paziņojumu, kurš ir vinnētājs
//            Console.WriteLine("Player " + checkForWinner() + " won the game!");
//        }
//        private static int checkForWinner()
//        {
//            // return a 0 if nobody won. return the player number if they won.

//            //top row
//            if (board[0] == board[1] && board[1] == board[2])
//            {
//                return board[0];
//            }
//            //second row
//            if (board[3] == board[4] && board[4] == board[5])
//            {
//                return board[3];
//            }
//            //third row
//            if (board[6] == board[7] && board[7] == board[8])
//            {
//                return board[6];
//            }
//            //first colum
//            if (board[0] == board[3] && board[3] == board[6])
//            {
//                return board[0];
//            }
//            //second colum
//            if (board[1] == board[4] && board[4] == board[7])
//            {
//                return board[1];
//            }
//            //third colum
//            if (board[2] == board[5] && board[5] == board[8])
//            {
//                return board[2];
//            }
//            //first diagonal
//            if (board[0] == board[4] && board[4] == board[8])
//            {
//                return board[0];
//            }
//            //second diagonal
//            if (board[2] == board[4] && board[4] == board[6])
//            {
//                return board[2];
//            }
//            //ja no visiem šiem 3 ifiem neviens nav true, tad atgriežam 0
//            return 0;
//        }
//        private static void printBoard()
//        {
//            for (int i = 0; i < 9; i++)
//            {
//                if (board[i] == 0)
//                {
//                    Console.Write(".");
//                }
//                if (board[i] == 1)
//                {
//                    Console.Write("X");
//                }
//                if (board[i] == 2)
//                {
//                    Console.Write("O");
//                }
//                if (i == 2 || i == 5 || i == 8)
//                {
//                    Console.WriteLine();
//                }

//            }
//        }
//    }
//}


// TicTacToe VARIANTS NR2.=======================================================================================================

//namespace TicTacToe
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            char player = 'X';

//            char[,] board = new char[3, 3];
//            Initialize(board);
//            int movesPlayed = 0; // ja ir DRAW neveiksme, neviens nav uzvarējis

//            while (true)
//            {
//                Console.Clear();
//                Print(board);

//                Console.Write("Please enter row: ");
//                int row = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Please enter col: ");
//                int col = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("row: " + row + " col: " + col);

//                board[row, col] = player;

//                //check if we won
//                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
//                {
//                    Console.WriteLine(player + "has won the game!");
//                    //Console.ReadKey() - NOMAINĀM uz šo gameEnd = true;
//                    // gameEnd = true; ŠO NOMAINĀM UZ break;
//                    break;
//                }
//                // pēc katra riņķa čeko vai nav DRAW
//                movesPlayed = movesPlayed + 1;

//                if (movesPlayed == 9) // ja ir bijuši 9 riņķi un ja nav atrasts vinētājs, tad ir GAME OVER
//                {
//                    Console.WriteLine("DRAW");
//                    break; // bez brake nerādīs DRAW
//                }

//                // Celebration For Winner.
//                // Clear the screen
//                // Print the Board
//                // Mention Who Won or If it was Draw



//                player = ChangeTurn(player);
//            }
//            static char ChangeTurn(char currentPlayer)
//            {
//                if (currentPlayer == 'X')
//                {
//                    return 'O';
//                }
//                else
//                {
//                    return 'X';
//                }
//            }
//            static void Initialize(char[,] board)
//            {
//                for (int row = 0; row < 3; row++)
//                {
//                    for (int col = 0; col < 3; col++)
//                    {
//                        board[row, col] = ' ';
//                    }
//                }
//            }
//            static void Print(char[,] board)
//            {
//                Console.WriteLine(" | 0 | 1 | 2 |");
//                for (int row = 0; row < 3; row++)
//                {
//                    Console.Write(row + "| ");
//                    for (int col = 0; col < 3; col++)
//                    {
//                        Console.Write(board[row, col]);
//                        Console.Write(" | ");
//                    }
//                    Console.WriteLine();
//                }
//            }
//        }
//    }
//}