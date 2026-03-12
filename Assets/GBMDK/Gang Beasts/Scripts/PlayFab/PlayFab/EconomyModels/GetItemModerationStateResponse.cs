using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemModerationStateResponse : PlayFabResultCommon
    {
        public ModerationState State;
    }
}