namespace TicTacToe
{

    public class Player
    {
        public Player(string name1)
        {
            Name = name1;
            Console.WriteLine($"Spēlētājs Nr.1 {name1} tavs simbols'X'");
        }
        public string Name { get; }



        public Player(string name2)
        {
            Name = name2;
            Console.WriteLine($"Spēlētājs Nr.2 {name2} tavs simbols'O'");
        }
             public string Name2 { get; }

    }
      

    
}      


