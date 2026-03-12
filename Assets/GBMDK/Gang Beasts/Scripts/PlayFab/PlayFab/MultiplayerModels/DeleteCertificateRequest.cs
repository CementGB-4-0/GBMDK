using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class DeleteCertificateRequest : PlayFabRequestCommon
    {
        public string Name;
        public Dictionary<string, string> CustomTags;
    }
}