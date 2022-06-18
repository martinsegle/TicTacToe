
using System;
using TicTacToe;

namespace TicTacToe
{

    class MainClass
    {

        public static void Main(string[] args)
        {
            string appName = Wellcome.ApplicationName;

            ConsoleLogger console = new ConsoleLogger();
            FileLogger file = new FileLogger();

            console.Log($"Wellcom to {appName}");
            file.Log($"Wellcom to {appName}");

            Console.WriteLine();

            HumanPlayer human = new HumanPlayer();

            Console.WriteLine("First player's name is?");
            string name1 = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(name1))
            {
                Console.WriteLine("You did not enter your name, please try again");
                name1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name1))
                {
                    Console.WriteLine($"You will BE a Player {human.Simbol}");
                }
                else
                {
                    Console.WriteLine($"Player {name1} play WITH {human.Simbol}");
                }
            }

            Console.WriteLine();

            Console.WriteLine($" {name1} choice 'x' or 'o'");
            string userText = Console.ReadLine();

            human.Name = name1;
            human.Simbol = userText;

            Console.WriteLine($"First Player {name1} play with {human.Simbol}");

            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine();

            HumanPlayer human2 = new HumanPlayer();

            string name2 = "";

            Console.WriteLine("If You are not computer write YES");

            string userChoise = Console.ReadLine();
            human2.Choise = userChoise;


            if (human2.Choise == "YES")
            {
                Console.WriteLine("Human player's name is?");
                name2 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name2))
                {
                    Console.WriteLine("You did not enter your name, please try again");
                    name2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(name2))
                    {
                        Console.WriteLine($"You will be a HUMAN {human2.Simbol}");
                    }
                    else
                    {
                        Console.WriteLine($"Human {name2} play WITH {human2.Simbol}");
                    }
                    human2.Name = name2;
                    human2.Player();
                }

            }
            else
            {
                ComputerPlayer computer = new ComputerPlayer();
                computer.Name = "Computer";
                computer.Computer();

            }
            human.Simbol = userText;
            if (human.Simbol == "x")
            {
                human2.Simbol = "o";
            }
            else
            {
                human2.Simbol = "x";
            }

            Console.WriteLine($"Second Player {name2} play with {human2.Simbol}");


            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.WriteLine($"Press ENTER to START {appName}");

            Console.ReadKey();

            HumanDesignation designation = HumanDesignation.First;
            char charValue = (char)designation;
            //char player = 'X';
            char player = charValue;
            string playerName = human.Name;

            int movesPlayed = 0; // ja ir DRAW neveiksme, neviens nav uzvarējis

            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', };


            while (true)
            {
                //    while (userTurn == -1 || arr[userTurn] !=0 )
                //    {
                //        Console.Write($" {playerName} ");
                //        userTurn = int.Parse(Console.ReadLine());
                //        Console.WriteLine("Youtype" + userTurn);
                //    }
                //    arr[userTurn] = 1;
                //    while (computerTurn == -1 || arr[computerTurn] != 0)
                //    {
                //        computerTurn = rand.Next(8);
                //        Console.WriteLine("Computer chooses " + computerTurn);
                //    }
                //    arr[computerTurn] = 2;

                Console.Clear();

                GameBoard.Board(arr);

                playerName = Player.ChangeName(name1, name2, playerName);

                Console.Write($"{playerName} LŪDZU izvēlēs brīvo skaitli" );

                int nummbers = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("With a Number: " + nummbers);

                player = Player.ChangeTurn(player);

                arr[nummbers - 1] = player;

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
                // pēc katra riņķa čeko vai nav DRAW, ja ir DRAW, tad neviens nav uzvarējis
                movesPlayed = movesPlayed + 1;

                if (movesPlayed == 9) // ja ir bijuši 9 riņķi un ja nav atrasts vinētājs, tad ir GAME OVER
                {
                    Console.WriteLine("Game Over (You have selected numbers 9 times)");
                    break; // bez brake nerādīs Game Over
                }

            }
        }
    }
}


