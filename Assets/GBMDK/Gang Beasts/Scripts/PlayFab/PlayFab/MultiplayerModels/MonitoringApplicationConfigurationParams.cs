using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MonitoringApplicationConfigurationParams : PlayFabBaseModel
    {
        public AssetReferenceParams AssetReference;

        public string ExecutionScriptName;

        public string InstallationScriptName;

        public double? OnStartRuntimeInMinutes;
    }
}