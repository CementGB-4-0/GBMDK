using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CreateUploadUrlsRequest : PlayFabRequestCommon
    {
        public List<UploadInfo> Files;
        public Dictionary<string, string> CustomTags;
    }
}