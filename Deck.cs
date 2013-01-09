using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            Cards.Add(new Card("Hearts", "2"));
            Cards.Add(new Card("Spades", "Ace"));
        }
    }
}
