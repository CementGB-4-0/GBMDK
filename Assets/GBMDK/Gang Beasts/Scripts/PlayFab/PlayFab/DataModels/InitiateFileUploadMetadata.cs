using System;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class InitiateFileUploadMetadata : PlayFabBaseModel
    {
        public string FileName;

        public string UploadUrl;
    }
}