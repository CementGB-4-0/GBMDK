using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class VmStartupScriptConfiguration : PlayFabBaseModel
    {
        public List<VmStartupScriptPortRequest> PortRequests;

        public AssetReference VmStartupScriptAssetReference;
    }
}