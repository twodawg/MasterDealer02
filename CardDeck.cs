using System.Collections.Generic;

namespace MasterDealer02
{
    class CardDeck
    {
        public List<Card> Cards { get; set; }
        public CardDeck()
        {
            Cards = new List<Card>();
        }
    }
}