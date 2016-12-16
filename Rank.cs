using System;
using System.Collections.Generic;

namespace MasterDealer02
{
    class Rank
    {
        public List<RankType> Ranks
        {
            get
            {
                return BuildRanks();
            }
        }

        private static List<RankType> BuildRanks()
        {
            var ranks = new List<RankType>();
            foreach (RankType rank in Enum.GetValues(typeof(RankType)))
            {
                ranks.Add(rank);
            }
            return ranks;
        }
    }
}