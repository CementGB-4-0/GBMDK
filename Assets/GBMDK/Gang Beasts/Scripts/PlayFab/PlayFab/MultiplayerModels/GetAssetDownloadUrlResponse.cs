using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetAssetDownloadUrlResponse : PlayFabResultCommon
    {
        public string AssetDownloadUrl;

        public string FileName;
    }
}