﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            foreach (Card card in myDeck.Cards)
            {
                Console.WriteLine(card.Suit);
            }

            //Card mycard = new Card("Hearts", "Two");

            //Console.WriteLine(mycard.Value);
            Console.ReadKey();
        }
    }
}
