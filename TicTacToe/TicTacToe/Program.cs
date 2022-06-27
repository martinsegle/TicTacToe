
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

            Console.WriteLine("If You are not computer write YES");

            string userChoise = Console.ReadLine();


            if (userChoise == "YES")
            {
                //izveidojam objektu
                HumanPlayer human1 = new HumanPlayer();
                human1.Player();
                human1.AskName();
                human1.AskSimbol();
                human1.ShowPlayerInfo();

                Console.WriteLine();

                HumanPlayer human2 = new HumanPlayer();

                Console.WriteLine("Second HUMAN");

                human2.AskName();

                if (human1.Simbol == "x")
                {
                    human2.Simbol = "o";
                }
                else
                {
                    human2.Simbol = "x";
                }
                human2.ShowPlayerInfo();

                Console.WriteLine();
                Console.WriteLine($"Press ENTER to START {appName}");
                Console.ReadKey();

                NewGame newGame = new NewGame();
                newGame.PlayGame(human1, human2);

            }
            else
            {
                ComputerPlayer computer = new ComputerPlayer();
                computer.Computer();
                computer.Name = "Computer";

                HumanPlayer human1 = new HumanPlayer();
                human1.AskName();
                human1.AskSimbol();
                human1.ShowPlayerInfo();

                if (human1.Simbol == "x")
                {
                    computer.Simbol = "o";
                }

                else 
                {
                    computer.Simbol = "x";
                }
                computer.ShowPlayerInfo();

                Console.WriteLine();

                Console.WriteLine($"Press ENTER to START {appName}");
                Console.ReadKey();

                NewGame newGame2 = new NewGame();
                newGame2.PlayGame(human1, computer);


            }
        }
    }
}



