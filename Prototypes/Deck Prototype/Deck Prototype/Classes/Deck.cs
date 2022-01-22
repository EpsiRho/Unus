using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Prototype.Classes
{
    /// <summary>
    /// The Deck of Unus Cards
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// The pile of cards that players draw from during play and during dealing.
        /// </summary>
        public List<Card> DrawPile { get; set; }

        /// <summary>
        /// The pile that players discard their cards to during play.
        /// </summary>
        public List<Card> DiscardPile { get; set; }

        public Deck()
        {
            DrawPile = new List<Card>();
            DiscardPile = new List<Card>();
        }

        /// <summary>
        /// Resets and fills the deck with a standard Unus card deck.
        /// </summary>
        public void FillStandardUnus()
        {
            DrawPile.Clear();
            DiscardPile.Clear();

            // Add Color Number Cards (except 0s)
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        DrawPile.Add(new Card(k, (Enums.CardColor)j, Enums.CardType.Color));
                    }
                }
            }

            // Add Zeros
            for (int j = 0; j < 4; j++)
            {
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.Color));
            }

            // Special Cards (except Color Switcher)
            for (int j = 0; j < 4; j++)
            {
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.Skip));
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.Reverse));
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.PlusTwo));
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.Skip));
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.Reverse));
                DrawPile.Add(new Card(0, (Enums.CardColor)j, Enums.CardType.PlusTwo));
            }

            // Color Action cards
            for (int j = 0; j < 4; j++)
            {
                DrawPile.Add(new Card(0, Enums.CardColor.Black, Enums.CardType.Color));
            }
            for (int j = 0; j < 4; j++)
            {
                DrawPile.Add(new Card(0, Enums.CardColor.Black, Enums.CardType.ColorPlusFour));
            }
        }

        /// <summary>
        /// Deals 7 cards to each player in the game.
        /// </summary>
        /// <param name="hands">A list of player's hands.</param>
        public void DealHands(List<Hand> hands)
        {
            for (int i = 0; i < 7; i++)
            {
                foreach (Hand hand in hands)
                {
                    Card random = null;
                    Random rand = new Random();
                    random = DrawPile[rand.Next(0, DrawPile.Count)];
                    hand.Cards.Add(random);
                    DrawPile.Remove(random);
                }
            }

            DiscardPile.Add(DrawPile.First());
            DrawPile.RemoveAt(0);
        }

        /// <summary>
        /// Shuffles the draw pile before game start.
        /// </summary>
        public void ShuffleDeck()
        {
            List<Card> Shuffled = new List<Card>();
            Random rand = new Random();
            while(DrawPile.Count > 0)
            {
                Card Transfer = DrawPile[rand.Next(0, DrawPile.Count - 1)];
                Shuffled.Add(Transfer);
                DrawPile.Remove(Transfer);
            }
            while (Shuffled.Count > 0)
            {
                Card Transfer = Shuffled[rand.Next(0, Shuffled.Count - 1)];
                Shuffled.Remove(Transfer);
                DrawPile.Add(Transfer);
            }
        }

        /// <summary>
        /// Shuffles the discarded cards for when draw pile is empty.
        /// </summary>
        public void ShuffleDiscarded()
        {

        }
    }
}
