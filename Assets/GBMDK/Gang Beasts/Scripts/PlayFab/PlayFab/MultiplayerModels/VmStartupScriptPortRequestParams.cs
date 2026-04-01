using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class VmStartupScriptPortRequestParams : PlayFabBaseModel
    {
        public string Name;

        public ProtocolType Protocol;
    }
}