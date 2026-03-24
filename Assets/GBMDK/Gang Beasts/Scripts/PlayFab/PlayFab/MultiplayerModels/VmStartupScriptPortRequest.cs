using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class VmStartupScriptPortRequest : PlayFabBaseModel
    {
        public string Name;

        public ProtocolType Protocol;
    }
}