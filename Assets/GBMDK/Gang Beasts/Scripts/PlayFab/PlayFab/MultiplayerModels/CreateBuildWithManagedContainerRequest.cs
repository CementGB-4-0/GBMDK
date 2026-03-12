using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateBuildWithManagedContainerRequest : PlayFabRequestCommon
    {
        public string BuildName;

        public List<AssetReferenceParams> GameAssetReferences;

        public List<GameCertificateReferenceParams> GameCertificateReferences;

        public string GameWorkingDirectory;

        public InstrumentationConfiguration InstrumentationConfiguration;

        public MonitoringApplicationConfigurationParams MonitoringApplicationConfiguration;

        public int MultiplayerServerCountPerVm;

        public List<Port> Ports;

        public List<BuildRegionParams> RegionConfigurations;

        public ServerResourceConstraintParams ServerResourceConstraints;

        public string StartMultiplayerServerCommand;

        public VmStartupScriptParams VmStartupScriptConfiguration;

        public WindowsCrashDumpConfiguration WindowsCrashDumpConfiguration;
        public bool? AreAssetsReadonly;

        public ContainerFlavor? ContainerFlavor;

        public Dictionary<string, string> CustomTags;

        public Dictionary<string, string> Metadata;

        [Obsolete("Use '' instead", false)] public bool? UseStreamingForAssetDownloads;

        public AzureVmSize? VmSize;
    }
}