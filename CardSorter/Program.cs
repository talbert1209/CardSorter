using System;
using System.Collections.Generic;

namespace CardSorter
{
    internal class Program
    {
        public static void PrintCards(List<Card> cards)
        {
            foreach (var card in cards)
                Console.WriteLine(card.Name);
        }

        private static void Main()
        {
            var random = new Random();

            var cards = new List<Card>
            {
                new Card((Suit) random.Next(4), (Value) random.Next(1, 14)),
                new Card((Suit) random.Next(4), (Value) random.Next(1, 14)),
                new Card((Suit) random.Next(4), (Value) random.Next(1, 14)),
                new Card((Suit) random.Next(4), (Value) random.Next(1, 14)),
                new Card((Suit) random.Next(4), (Value) random.Next(1, 14))
            };

            Console.WriteLine("Five Random Cards:");
            PrintCards(cards);

            Console.WriteLine();
            Console.WriteLine("Those Same Cards Sorted By Value Then Suit:");
            var sortCardsByValueFirst = new SortCardsByValueThenSuit();
            cards.Sort(sortCardsByValueFirst);
            PrintCards(cards);

            Console.WriteLine();
            Console.WriteLine("Those Same Cards Sorted By Suit Then Value:");
            var sortCardsBySuitFirst = new SortCardsBySuitThenValue();
            cards.Sort(sortCardsBySuitFirst);
            PrintCards(cards);

            Console.ReadKey();
        }
    }
}
