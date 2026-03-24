using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CreateUploadUrlsResponse : PlayFabResultCommon
    {
        public List<UploadUrlMetadata> UploadUrls;
    }
}