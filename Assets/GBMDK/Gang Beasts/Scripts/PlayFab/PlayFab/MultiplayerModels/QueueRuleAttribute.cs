using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class QueueRuleAttribute : PlayFabBaseModel
    {
        public string Path;

        public AttributeSource Source;
    }
}