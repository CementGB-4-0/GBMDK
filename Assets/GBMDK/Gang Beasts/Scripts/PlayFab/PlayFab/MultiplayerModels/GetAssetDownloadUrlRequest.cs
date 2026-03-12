using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetAssetDownloadUrlRequest : PlayFabRequestCommon
    {
        public string FileName;
        public Dictionary<string, string> CustomTags;
    }
}