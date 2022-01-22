using Deck_Prototype.Classes;
using System.Text;

Console.ForegroundColor = ConsoleColor.White;
int PlayerCount = 0;
bool fail = true;
while (fail == true)
{
    Console.Clear();
    Console.WriteLine("┌───Unus Deck Prototype───┐");
    Console.WriteLine("│ How Many Players 1->4:  │");
    Console.WriteLine("├─────────────────────────┘");
    Console.Write("└┤ ");
    string input = Console.ReadLine();
    try
    {
        PlayerCount = Convert.ToInt16(input);
        fail = false;
        if(PlayerCount < 2 || PlayerCount > 4)
        {
            fail = true;
            Console.Clear();
            Console.WriteLine("┌───Unus Deck Prototype───┐");
            Console.WriteLine("│ Input must be 1 -> 4    │");
            Console.WriteLine("└─────────────────────────┘");
            Console.CursorVisible = false;
            Console.WriteLine("       / Hit Enter /       ");
            Console.ReadLine();
            Console.CursorVisible = true;

        }
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine("┌───Unus Deck Prototype───┐");
        Console.WriteLine("│ Input must be 1 -> 4    │");
        Console.WriteLine("└─────────────────────────┘");
        Console.CursorVisible = false;
        Console.WriteLine("       / Hit Enter /       ");
        Console.ReadLine();
        Console.CursorVisible = true;
    }
}

Console.Clear();
Console.WriteLine("┌───Unus Deck Prototype───┐");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("[###] Initializing Deck  ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.WriteLine("│[ ] Shuffling Deck       │");
Console.WriteLine("│[ ] Dealing Hands        │");
Console.WriteLine("├─────────────────────────┤");

for(int i = 0; i < PlayerCount; i++)
{
    Console.WriteLine($"│[ ] Player {i+1}:            │");

}

Console.WriteLine("│                         │");
Console.WriteLine("└─────────────────────────┘");

List<Hand> Players = new List<Hand>();
for(int i = 0; i < PlayerCount; i++)
{
    Players.Add(new Hand());
}


Deck GameDeck = new Deck();
GameDeck.FillStandardUnus();

Console.Clear();
Console.WriteLine("┌───Unus Deck Prototype───┐");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"[{GameDeck.DrawPile.Count}] Initializing Deck  ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"[ ] Shuffling Deck       ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("[ ] Dealing Hands        ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("├─────────────────────────┤");

for (int i = 0; i < PlayerCount; i++)
{
    Console.WriteLine($"│[ ] Player {i + 1}:            │");

}

Console.WriteLine("│                         │");
Console.WriteLine("└─────────────────────────┘");

GameDeck.ShuffleDeck();

Console.Clear();
Console.WriteLine("┌───Unus Deck Prototype───┐");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"[{GameDeck.DrawPile.Count}] Initializing Deck  ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"[✓] Shuffling Deck       ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("[ ] Dealing Hands        ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("├─────────────────────────┤");

for (int i = 0; i < PlayerCount; i++)
{
    Console.WriteLine($"│[ ] Player {i + 1}:            │");

}

Console.WriteLine("│                         │");
Console.WriteLine("└─────────────────────────┘");

GameDeck.DealHands(Players);

Console.Clear();
Console.WriteLine("┌───Unus Deck Prototype───┐");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"[{GameDeck.DrawPile.Count}] Initializing Deck   ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"[✓] Shuffling Deck       ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.Write("│");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("[✓] Dealing Hands        ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("│");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("├─────────────────────────┤");

for (int i = 0; i < PlayerCount; i++)
{
    Console.WriteLine($"│[{Players[i].Cards.Count}] Player {i + 1}:            │");

}

Console.WriteLine("│                         │");
Console.WriteLine("└─────────────────────────┘");

string bldr = " Player 1: 000 000 000 000 000 000 000 ";

Console.Write($"┌");
for (int i = 0; i < bldr.Length; i++)
{
    Console.Write("─");
}
Console.WriteLine("┐");
for (int i = 0; i < PlayerCount; i++)
{
    Console.Write($"│ Player {i}: ");
    for(int k = 0; k < 7; k++)
    {
        Console.Write($"{Players[i].Cards[k].Number}{(int)Players[i].Cards[k].Color}{(int)Players[i].Cards[k].Type} ");
    }
    Console.WriteLine($"│");
}
Console.Write($"└");
for (int i = 0; i < bldr.Length; i++)
{
    Console.Write("─");
}
Console.WriteLine("┘");