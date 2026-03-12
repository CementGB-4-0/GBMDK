using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class AssetSummary : PlayFabBaseModel
    {
        public string FileName;

        public Dictionary<string, string> Metadata;
    }
}