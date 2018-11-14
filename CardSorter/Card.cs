namespace CardSorter
{
    public class Card
    {
        public Suit Suit { get; private set; }
        public Value Value { get; private set; }
        public string Name { get; private set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
            Name = $"{Value} of {Suit}";
        }
    }
}