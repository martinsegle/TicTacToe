using TicTacToe;

Player player1 = new Player ();

Console.WriteLine("Spēlētājs Nr.1 Ievadi savu vārdu");
string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace (name))
{
    Console.WriteLine("Tu neievadīji savu vārdu");
    Console.WriteLine("Mēģini vēlreiz");
    name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace (name))
    {
        Console.WriteLine("Jūs būsiet bezvādis");
    }
    else
    {
        Console.WriteLine($"Tavs vārds ir: {name}");
    }
}


Player player2 = new Player();
Console.WriteLine("Spēlētājs Nr.2 Ievadi savu vārdu");