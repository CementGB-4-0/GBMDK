using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class SubscribeToMatchResourceResult : PlayFabResultCommon
    {
        public string Topic;
    }
}