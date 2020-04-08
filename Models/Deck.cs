using System;
using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public class Deck
    {
    
        private static List<Card> _deck;

        public int Size {
            get {
                return _deck.Count;
            }
        }
        public void Display()
        {
            foreach(Card card in _deck)
            {
                Console.WriteLine( card.Display() );
            }
        }
        public Deck()
        {
            Reset();
            
        }
        public Card Deal()
        {
            Card card = _deck[0];
            _deck.RemoveAt(0);
            return card;
        }
        public List<Card> Deal(int num)
        {
            List<Card> cards = new List<Card>();
            while(num > 0){
                Card card = _deck[0];
                _deck.Remove(card);
                cards.Add( card );
                num--;
            }
            return cards;
        }
        public static void Reset()
        {
            _deck = new List<Card>();
            String[] values = { "Ace", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "Queen" };
            String[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
            for (int i = 0; i < suits.Length; i++)
            {
                for (int k = 0; k < values.Length; k++){
                    _deck.Add(
                        new Card(values[k], suits[i], (k + 1))
                    );
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i < _deck.Count; i++)
            {
                int idx = rand.Next(_deck.Count);
                Card temp = _deck[i];
                _deck[i] = _deck[idx];
                _deck[idx] = temp;
            }
        }
    }
}