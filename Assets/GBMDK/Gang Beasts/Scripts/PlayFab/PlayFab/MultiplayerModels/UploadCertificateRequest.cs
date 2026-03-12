using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class UploadCertificateRequest : PlayFabRequestCommon
    {
        public Certificate GameCertificate;
        public Dictionary<string, string> CustomTags;
    }
}