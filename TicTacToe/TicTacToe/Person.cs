
namespace TicTacToe
{
    public class Person
    {
        public Person(string playername)
        {
            Name = playername;
            Console.WriteLine($"Spēlētājs Nr.1 {playername}");
        }
        public string Name { get; }

    }
}
