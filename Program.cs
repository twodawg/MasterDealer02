using System;

namespace MasterDealer02
{
    public class Program
    {
        public static void Main()
        {
            var cardDeck = BuildDeck();

            FisherYatesShuffle.Shuffle(cardDeck.Cards);

            while (true)
            {
                Console.WriteLine("How many cards would you like?");

                var numberCardsInputted = Console.ReadLine();

                if (string.IsNullOrEmpty(numberCardsInputted)) break;

                int numberCards;
                if (!int.TryParse(numberCardsInputted, out numberCards)) break;

                try
                {
                    for (int i = 0; i < numberCards; i++)
                        Console.WriteLine(cardDeck.Cards[i]);

                    for (int i = 0; i < numberCards; i++)
                        cardDeck.Cards.RemoveAt(i);
                }
                catch (ArgumentOutOfRangeException argEx)
                {
                    Console.WriteLine("No more cards, game over.");
                    break;
                }
            }
            Console.ReadLine();
        }
        private static CardDeck BuildDeck()
        {
            var suit = new Suit();
            var rank = new Rank();
            var cardDeck = new CardDeck();

            for (int i = 0; i < rank.Ranks.Count; i++)
            {
                for (int s = 0; s < suit.Suits.Length; s++)
                {
                    //CardValue(rank.Ranks[i].ToString(), suit.Suits[s].ToString());
                    cardDeck.Cards.Add(new Card(rank.Ranks[i], suit.Suits[s]));
                }
            }

            return cardDeck;
        }

    }
}
