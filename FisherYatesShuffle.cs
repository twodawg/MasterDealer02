using System;
using System.Collections.Generic;

namespace MasterDealer02
{
    class FisherYatesShuffle
    {
        static Random r = new Random();
        //  Based on Java code from wikipedia:
        //  http://en.wikipedia.org/wiki/Fisher-Yates_shuffle
        static public void Shuffle(List<Card> deck)
        {
            for (int n = deck.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }
    }
}