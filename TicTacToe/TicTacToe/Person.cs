
namespace TicTacToe
{
    public class Person
    {
        public Person(string playername)
        {
            Name = playername;
            Console.WriteLine($" {playername}");
        }
        public string Name { get; }
        public string Simbol { get; set; }

    }

}
