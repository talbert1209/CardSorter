using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorter
{
    class Program
    {
        public static void PrintCards(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            var cards = new List<Card>()
            {
                new Card((Suit)random.Next(4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(4), (Value)random.Next(1,14)),
                new Card((Suit)random.Next(4), (Value)random.Next(1,14)),
            };

            Console.WriteLine("Five Random Cards:");
            PrintCards(cards);

            var sortCards = new SortCards();
            cards.Sort(sortCards);

            Console.WriteLine();
            Console.WriteLine("Those Same Cards Sorted:");
            PrintCards(cards);

            Console.ReadKey();
        }
    }
}
