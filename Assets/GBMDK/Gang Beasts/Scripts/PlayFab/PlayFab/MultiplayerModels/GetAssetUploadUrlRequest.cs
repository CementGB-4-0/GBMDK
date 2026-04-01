using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetAssetUploadUrlRequest : PlayFabRequestCommon
    {
        public string FileName;
        public Dictionary<string, string> CustomTags;
    }
}