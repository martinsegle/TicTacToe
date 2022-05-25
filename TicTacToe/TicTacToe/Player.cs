
namespace TicTacToe
{
    public class Player
    {
       
        public Player (string name) 
        {
            Name = name;

            Console.WriteLine($"Spēlētājs{name}");
        }
     

         public string Name { get; }
    }
}
