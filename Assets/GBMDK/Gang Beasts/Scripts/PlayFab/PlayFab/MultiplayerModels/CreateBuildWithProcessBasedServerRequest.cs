using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateBuildWithProcessBasedServerRequest : PlayFabRequestCommon
    {
        public string BuildName;

        public List<AssetReferenceParams> GameAssetReferences;

        public List<GameCertificateReferenceParams> GameCertificateReferences;

        public string GameWorkingDirectory;

        public InstrumentationConfiguration InstrumentationConfiguration;

        public MonitoringApplicationConfigurationParams MonitoringApplicationConfiguration;

        public int MultiplayerServerCountPerVm;

        public string OsPlatform;

        public List<Port> Ports;

        public List<BuildRegionParams> RegionConfigurations;

        public string StartMultiplayerServerCommand;

        public VmStartupScriptParams VmStartupScriptConfiguration;
        public bool? AreAssetsReadonly;

        public Dictionary<string, string> CustomTags;

        public bool? IsOSPreview;

        public Dictionary<string, string> Metadata;

        [Obsolete("Use '' instead", false)] public bool? UseStreamingForAssetDownloads;

        public AzureVmSize? VmSize;
    }
}