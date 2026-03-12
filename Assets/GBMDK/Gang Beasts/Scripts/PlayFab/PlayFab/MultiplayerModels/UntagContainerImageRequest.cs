using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class UntagContainerImageRequest : PlayFabRequestCommon
    {
        public string ImageName;

        public string Tag;
        public Dictionary<string, string> CustomTags;
    }
}