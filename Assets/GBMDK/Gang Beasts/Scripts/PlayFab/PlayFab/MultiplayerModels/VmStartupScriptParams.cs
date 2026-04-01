using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class VmStartupScriptParams : PlayFabBaseModel
    {
        public List<VmStartupScriptPortRequestParams> PortRequests;

        public AssetReferenceParams VmStartupScriptAssetReference;
    }
}