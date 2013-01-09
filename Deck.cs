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
            Cards.Add(new Card("Hearts", "3"));
            Cards.Add(new Card("Hearts", "4"));
            Cards.Add(new Card("Hearts", "5"));
            Cards.Add(new Card("Hearts", "6"));
            Cards.Add(new Card("Hearts", "7"));
            Cards.Add(new Card("Hearts", "8"));
            Cards.Add(new Card("Hearts", "9"));
            Cards.Add(new Card("Hearts", "10"));
            Cards.Add(new Card("Hearts", "King"));
            Cards.Add(new Card("Hearts", "Queen"));
            Cards.Add(new Card("Hearts", "Ace"));
            Cards.Add(new Card("Hearts", "Jack"));
            Cards.Add(new Card("Spades", "2"));
            Cards.Add(new Card("Spades", "3"));
            Cards.Add(new Card("Spades", "4"));
            Cards.Add(new Card("Spades", "5"));
            Cards.Add(new Card("Spades", "6"));
            Cards.Add(new Card("Spades", "7"));
            Cards.Add(new Card("Spades", "8"));
            Cards.Add(new Card("Spades", "9"));
            Cards.Add(new Card("Spades", "10"));
            Cards.Add(new Card("Spades", "Ace"));
            Cards.Add(new Card("Spades", "King"));
            Cards.Add(new Card("Spades", "Queen"));
            Cards.Add(new Card("Spades", "Jack"));
            Cards.Add(new Card("Diamonds", "2"));
            Cards.Add(new Card("Diamonds", "3"));
            Cards.Add(new Card("Diamonds", "4"));
            Cards.Add(new Card("Diamonds", "5"));
            Cards.Add(new Card("Diamonds", "6"));
            Cards.Add(new Card("Diamonds", "7"));
            Cards.Add(new Card("Diamonds", "8"));
            Cards.Add(new Card("Diamonds", "9"));
            Cards.Add(new Card("Diamonds", "10"));
            Cards.Add(new Card("Diamonds", "Ace"));
            Cards.Add(new Card("Diamonds", "King"));
            Cards.Add(new Card("Diamonds", "Queen"));
            Cards.Add(new Card("Diamonds", "Jack"));
            Cards.Add(new Card("Club", "2"));
            Cards.Add(new Card("Club", "3"));
            Cards.Add(new Card("Club", "4"));
            Cards.Add(new Card("Club", "5"));
            Cards.Add(new Card("Club", "6"));
            Cards.Add(new Card("Club", "7"));
            Cards.Add(new Card("Club", "8"));
            Cards.Add(new Card("Club", "9"));
            Cards.Add(new Card("Club", "10"));
            Cards.Add(new Card("Club", "Ace"));
            Cards.Add(new Card("Club", "King"));
            Cards.Add(new Card("Club", "Queen"));
            Cards.Add(new Card("Club", "Jack"));

        }
    }
}
