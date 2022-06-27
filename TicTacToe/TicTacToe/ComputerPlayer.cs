
namespace TicTacToe
{
    public class ComputerPlayer : BasePlayer
    {

        public void ComputerTurn()
        {

            //    while (userTurn == -1 || arr[userTurn] != 0)
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
        }
        public void Computer()
        {
            Console.WriteLine($"COMPUTER will play with HUMAN");

        }
        public override int MakeMove()
        {
            //random izvēlas rndom nr.
            Random random = new Random();
            int computerNumber = random.Next(1, 10);
            Console.WriteLine($"COMPUTER choice {computerNumber} press ENTER to continue");
            Console.ReadKey();


            return computerNumber;



            }
        }
    }


