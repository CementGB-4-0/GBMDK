using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class UploadUrlMetadata : PlayFabBaseModel
    {
        public string FileName;

        public string Id;

        public string Url;
    }
}