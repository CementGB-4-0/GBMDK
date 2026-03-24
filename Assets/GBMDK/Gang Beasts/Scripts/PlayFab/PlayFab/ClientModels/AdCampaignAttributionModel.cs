using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class AdCampaignAttributionModel : PlayFabBaseModel
    {
        public string CampaignId;

        public string Platform;
        public DateTime AttributedAt;
    }
}