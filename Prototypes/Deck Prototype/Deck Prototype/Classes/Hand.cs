using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Prototype.Classes
{
    /// <summary>
    /// A player's Hand
    /// </summary>
    public class Hand
    {
        /// <summary>
        /// The cards in the players hand
        /// </summary>
        public List<Card> Cards { get; set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        /// <summary>
        /// Adds a new card to the hand.
        /// </summary>
        /// <param name="c"></param>
        public void AddCardToHand(Card c)
        {
            Cards.Add(c);
        }

        /// <summary>
        /// Removes a card from the hand.
        /// </summary>
        /// <param name="c"></param>
        public void RemoveCardFromHand(Card c)
        {
            Cards.Remove(c);
        }
    }
}
