using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchmakingQueueConfig : PlayFabBaseModel
    {
        public BuildAliasParams BuildAliasParams;

        public string BuildId;

        public List<DifferenceRule> DifferenceRules;

        public List<MatchTotalRule> MatchTotalRules;

        public uint MaxMatchSize;

        public uint MinMatchSize;

        public string Name;

        public RegionSelectionRule RegionSelectionRule;

        public bool ServerAllocationEnabled;

        public List<SetIntersectionRule> SetIntersectionRules;

        public StatisticsVisibilityToPlayers StatisticsVisibilityToPlayers;

        public List<StringEqualityRule> StringEqualityRules;

        public List<TeamDifferenceRule> TeamDifferenceRules;

        public List<MatchmakingQueueTeam> Teams;

        public TeamSizeBalanceRule TeamSizeBalanceRule;

        public TeamTicketSizeSimilarityRule TeamTicketSizeSimilarityRule;

        public uint? MaxTicketSize;
    }
}