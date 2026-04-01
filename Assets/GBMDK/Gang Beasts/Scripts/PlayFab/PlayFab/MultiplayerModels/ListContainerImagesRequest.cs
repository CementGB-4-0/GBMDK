using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ListContainerImagesRequest : PlayFabRequestCommon
    {
        public string SkipToken;
        public Dictionary<string, string> CustomTags;

        public int? PageSize;
    }
}