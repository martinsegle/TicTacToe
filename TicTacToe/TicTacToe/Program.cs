using TicTacToe;

string appName = Configuration.ApplicationName;

Console.WriteLine($"Wellcome to {appName}");
Console.WriteLine();
string gridGrid1 = Configuration.Grid1;
Console.WriteLine($"{gridGrid1}");
string gridGrid2 = Configuration.Grid2;
Console.WriteLine($"{gridGrid2}");
string gridGrid3 = Configuration.Grid3;
Console.WriteLine($"{gridGrid3}");
string gridGrid4 = Configuration.Grid4;
Console.WriteLine($"{gridGrid4}");
string gridGrid5 = Configuration.Grid5;
Console.WriteLine($"{gridGrid5}");
string gridGrid6 = Configuration.Grid6;
Console.WriteLine($"{gridGrid6}");
string gridGrid7 = Configuration.Grid7;
Console.WriteLine($"{gridGrid7}");
string gridGrid8 = Configuration.Grid8;
Console.WriteLine($"{gridGrid8}");
string gridGrid9 = Configuration.Grid9;
Console.WriteLine($"{gridGrid9}");
string gridGrid10 = Configuration.Grid10;
Console.WriteLine($"{gridGrid10}");
string gridGrid11 = Configuration.Grid11;
Console.WriteLine($"{gridGrid11}");

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

Console.WriteLine();
Console.WriteLine("============= TicTacToe =================");
Console.WriteLine();

namespace TicTacToe
{
    class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {
            //ŠO VAR SAĪSINĀT ar "for (int i = 0; i <9; i++) {board[i] = 0;} ZEMĀK KAS IR"
            //board[0] = 0;
            //board[1] = 0;
            //board[2] = 0;
            //board[3] = 0;
            //board[4] = 0;
            //board[5] = 0;
            //board[6] = 0;
            //board[7] = 0;
            //board[8] = 0;
            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }

            int userTurn = -1;  // jāiedod vērtība lai "while (board[userTurn] ! = 0)" nebūtu pasvītrots kā kļūda
            int computerTurn = -1;

            Random rand = new Random();

            // izveidojot "private static int checkForWiner" šis "while(true)" mainās uz:
            while (checkForWinner() == 0)
            { // prasa call chec for winners

                // dont allow the human to choose an already occupied square
                while (userTurn == -1 || board[userTurn] != 0)
                {
                    Console.WriteLine("Please enter a number from 0 to 8");

                    userTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("You type" + userTurn);
                }

                board[userTurn] = 1;

                // dont let the computer pick an invalid number
                while (computerTurn == -1 || board[computerTurn] != 0)
                {
                    computerTurn = rand.Next(8);
                    // board[computerTurn] = 2; // savādāk never ending story
                    Console.WriteLine("Computer chooses " + computerTurn);
                }

                board[computerTurn] = 2;
                printBoard();
            }
            // Kad savadīts "private static int chechForWinner()"
            // tad arī izveidi šo paziņojumu, kurš ir vinnētājs
            Console.WriteLine("Player " + checkForWinner() + " won the the game!");
        }
        private static int checkForWinner()
        {
            // return a 0 if nobody won. return the player number if they won.

            //top row
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }
            //second row
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }
            //third row
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }
            //first colum
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }
            //second colum
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }
            //third colum
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }
            //first diagonal
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }
            //second diagonal
            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }
            //ja no visiem šiem 3 ifiem neviens nav true, tad atgriežam 0
            return 0;
        }
        private static void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("X");
                }
                if (board[i] == 2)
                {
                    Console.Write("O");
                }
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}


