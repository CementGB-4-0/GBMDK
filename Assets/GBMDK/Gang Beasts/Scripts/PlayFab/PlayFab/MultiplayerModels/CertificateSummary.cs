using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CertificateSummary : PlayFabBaseModel
    {
        public string Name;

        public string Thumbprint;
    }
}