using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DeleteContainerImageRequest : PlayFabRequestCommon
    {
        public string ImageName;
        public Dictionary<string, string> CustomTags;
    }
}