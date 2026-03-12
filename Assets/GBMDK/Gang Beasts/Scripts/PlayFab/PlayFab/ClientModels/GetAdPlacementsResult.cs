using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetAdPlacementsResult : PlayFabResultCommon
    {
        public List<AdPlacementDetails> AdPlacements;
    }
}