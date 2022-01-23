using Deck_Prototype.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Prototype.Classes
{
    /// <summary>
    /// An Unus card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The card's number.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The type of card, ex: Normal, Color, PlusTwo, etc
        /// </summary>
        public CardType Type { get; set; }

        /// <summary>
        /// The card's color.
        /// </summary>
        public CardColor Color { get; set; }

        public Card(int num, CardColor clr, CardType typ)
        {
            Number = num;
            Type = typ;
            Color = clr;
        }
    }
}
