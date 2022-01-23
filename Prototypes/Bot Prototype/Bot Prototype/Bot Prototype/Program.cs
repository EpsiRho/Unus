using Deck_Prototype.Classes;
using Deck_Prototype.Enums;

List<Hand> Players = new List<Hand>();
Players.Add(new Hand());
Deck GameDeck = new Deck();
GameDeck.FillStandardUnus();
GameDeck.ShuffleDeck();
GameDeck.DealHands(Players);
int count = 0;
while (true)
{
    var Indexes = GameDeck.CheckHand(Players[0]);
    Console.Clear();
    Console.WriteLine($"Your Hand:");
    foreach (Card card in Players[0].Cards)
    {

        switch (card.Color)
        {
            case CardColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case CardColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case CardColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case CardColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case CardColor.Black:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.Write($"┌───────┐");
    }
    Console.WriteLine("");
    foreach (Card card in Players[0].Cards)
    {
        switch (card.Color)
        {
            case CardColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case CardColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case CardColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case CardColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case CardColor.Black:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.Write($"│{card.Number}      │");
    }
    Console.WriteLine("");
    foreach (Card card in Players[0].Cards)
    {
        switch (card.Color)
        {
            case CardColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case CardColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case CardColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case CardColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case CardColor.Black:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }

        Console.Write($"│   {(int)card.Type}   │");
    }
    Console.WriteLine("");
    foreach (Card card in Players[0].Cards)
    {
        switch (card.Color)
        {
            case CardColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case CardColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case CardColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case CardColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case CardColor.Black:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }

        if (Indexes.Contains(count))
        {
            Console.Write($"│      ✓│");
        }
        else
        {
            Console.Write($"│      X│");
        }
        Console.BackgroundColor = ConsoleColor.Black;
        count++;
    }
    Console.WriteLine("");
    count = 0;
    foreach (Card card in Players[0].Cards)
    {
        switch (card.Color)
        {
            case CardColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case CardColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case CardColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case CardColor.Blue:
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case CardColor.Black:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }

        Console.Write($"└───────┘");
    }
    Console.WriteLine("");
    //foreach (Card card in Players[0].Cards)
    //{
    //    Console.WriteLine($"> {card.Number} / {card.Color} / {card.Type}");

    //}
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nTop Card:");

    Card TopCard = GameDeck.DiscardPile.Last();
    switch (TopCard.Color)
    {
        case CardColor.Red:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case CardColor.Green:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case CardColor.Yellow:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case CardColor.Blue:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case CardColor.Black:
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }

    Console.WriteLine($"┌───────┐");
    Console.WriteLine($"│{TopCard.Number}      │");
    Console.WriteLine($"│   {(int)TopCard.Type}   │");
    Console.WriteLine($"│      {TopCard.Number}│");
    Console.WriteLine($"└───────┘\n");
    Console.ForegroundColor = ConsoleColor.White;
    if (Indexes.Count > 0)
    {
        while (true)
        {
            Console.WriteLine("What card would you like to play (Enter Index, starting at 1)");
            string x = Console.ReadLine();
            int index = -1;
            if (int.TryParse(x, out index))
            {
                index -= 1;
                if (Indexes.Contains(index))
                {
                    Card c = Players[0].Cards[index];
                    GameDeck.DiscardPile.Add(c);
                    Players[0].Cards.Remove(c);
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorLeft = 0;
            Console.CursorTop--;
            Console.Write("                                      ");
            Console.CursorLeft = 0;
            Console.CursorTop -= 2;
            Console.WriteLine("Error: Invalid index                                              ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else
    {
        Console.WriteLine("Press Enter to start drawing cards");
        Console.ReadLine();

        while (true)
        {
            Card DrawCard = GameDeck.DrawPile.Last();
            GameDeck.DrawPile.Remove(DrawCard);
            bool CanPlay = GameDeck.CheckCard(DrawCard, GameDeck.DiscardPile.Last());

            switch (DrawCard.Color)
            {
                case CardColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case CardColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case CardColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case CardColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case CardColor.Black:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine($"┌───────┐");
            Console.WriteLine($"│{DrawCard.Number}      │");
            Console.WriteLine($"│   {(int)DrawCard.Type}   │");
            if (CanPlay)
            {
                Console.WriteLine($"│      ✓│");
            }
            else
            {
                Console.WriteLine($"│      X│");
            }
            Console.WriteLine($"└───────┘\n");
            Console.ForegroundColor = ConsoleColor.White;

            if (CanPlay)
            {
                Console.WriteLine($"This card can be played!  ");
                Console.ReadLine();
                GameDeck.DiscardPile.Add(DrawCard);
                break;
            }
            else
            {
                Console.WriteLine($"This card cant be played.");
                Console.ReadLine();
                Players[0].Cards.Add(DrawCard);
            }
            Console.CursorTop -= 8;
        }
    }
}