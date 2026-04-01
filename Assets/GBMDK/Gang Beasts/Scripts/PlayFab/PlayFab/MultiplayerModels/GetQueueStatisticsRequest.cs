using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetQueueStatisticsRequest : PlayFabRequestCommon
    {
        public string QueueName;
        public Dictionary<string, string> CustomTags;
    }
}