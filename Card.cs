namespace MasterDealer02
{
    class Card
    {
        public RankType CardRank { get; private set; }
        public SuitType CardSuit { get; private set; }

        public Card(RankType rank, SuitType suit)
        {
            CardRank = rank;
            CardSuit = suit;
        }
        public override string ToString()
        {
            return $"{ CardRank } of { CardSuit }";
        }
    }
}