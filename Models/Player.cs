using System;
using System.Collections.Generic;

namespace DeckOfCards.Models
{

// Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
// Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
// Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.
    public class Player
    {
        public string Name;
        private List<Card> _hand;
        private Deck _deckInstance;

        /// <summary>
        /// This is a cool technique!!!
        /// </summary>
        public Player(Deck deckInstance, string name = "Jerry")
        {
            Name = name;
            _hand = new List<Card>();
            _deckInstance = deckInstance;
        }
        public void Draw(int num = 1) {
            List<Card> newCards = _deckInstance.Deal(num);
            foreach(Card card in newCards)
            {
                _hand.Add(card);
                _deckInstance.Deal();
            }
        }
        public void Display()
        {
            Console.WriteLine($"{Name} is packing {_hand.Count} card(s)");
            foreach(Card c in _hand)
            {
                Console.WriteLine( c.Display() );
            }
        }
    }
}