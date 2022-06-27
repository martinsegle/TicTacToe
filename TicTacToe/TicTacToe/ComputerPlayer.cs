
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
        public override int MakeMove()
        {
            Random random = new Random();
            int computerNumber = random.Next(1, 10);

            return computerNumber;
        }
    }
}

