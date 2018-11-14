namespace CardSorter
{
    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }
        public string Name { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
            Name = $"{Value} of {Suit}";
        }
    }
}