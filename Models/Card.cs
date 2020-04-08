namespace DeckOfCards.Models
{
    public class Card
    {
        public string StringVal{ get; }
        public string Suit{ get; }
        public int Val{ get; }
        public Card(string stringval, string suit, int val)
        {
            StringVal = stringval;
            Suit = suit;
            Val = val;
        }
        public string Display()
        {
            return $"card is {StringVal} of {Suit}";
        }
    }
}