using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetTitleMultiplayerServersQuotasResponse : PlayFabResultCommon
    {
        public TitleMultiplayerServersQuotas Quotas;
    }
}