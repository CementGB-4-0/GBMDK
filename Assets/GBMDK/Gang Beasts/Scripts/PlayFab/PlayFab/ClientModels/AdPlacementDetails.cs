using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class AdPlacementDetails : PlayFabBaseModel
    {
        public string PlacementId;

        public string PlacementName;

        public string RewardAssetUrl;

        public string RewardDescription;

        public string RewardId;

        public string RewardName;

        public int? PlacementViewsRemaining;

        public double? PlacementViewsResetMinutes;
    }
}