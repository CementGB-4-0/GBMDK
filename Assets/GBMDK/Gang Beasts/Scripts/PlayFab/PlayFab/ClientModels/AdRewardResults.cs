using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class AdRewardResults : PlayFabBaseModel
    {
        public List<AdRewardItemGranted> GrantedItems;

        public Dictionary<string, int> GrantedVirtualCurrencies;

        public Dictionary<string, int> IncrementedStatistics;
    }
}