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
