using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetItemPublishStatusResponse : PlayFabResultCommon
    {
        public string StatusMessage;
        public PublishResult? Result;
    }
}