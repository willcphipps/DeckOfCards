using System;
using System.Collections.Generic;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck cards = new Deck();
            cards.Shuffle();
            // cards.Display();
            // Console.WriteLine("-------------------");
            // Card test = cards.Deal();
            // Console.WriteLine(test.Display());
            // List<Card> paw = cards.Deal(5);
            // foreach(Card x in paw)
            // {
            //     Console.Write(x.Display() + " | ");
            // }
            Player Morty = new Player(cards, "Morty");
            Morty.Draw(5);
            Morty.Display();
            Console.WriteLine(cards.Size);
        }
    }
}
