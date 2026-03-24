using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MonitoringApplicationConfiguration : PlayFabBaseModel
    {
        public AssetReference AssetReference;

        public string ExecutionScriptName;

        public string InstallationScriptName;

        public double? OnStartRuntimeInMinutes;
    }
}