using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateBuildWithCustomContainerRequest : PlayFabRequestCommon
    {
        public string BuildName;

        public ContainerImageReference ContainerImageReference;

        public string ContainerRunCommand;

        public List<AssetReferenceParams> GameAssetReferences;

        public List<GameCertificateReferenceParams> GameCertificateReferences;

        public LinuxInstrumentationConfiguration LinuxInstrumentationConfiguration;

        public MonitoringApplicationConfigurationParams MonitoringApplicationConfiguration;

        public int MultiplayerServerCountPerVm;

        public List<Port> Ports;

        public List<BuildRegionParams> RegionConfigurations;

        public ServerResourceConstraintParams ServerResourceConstraints;

        public VmStartupScriptParams VmStartupScriptConfiguration;
        public bool? AreAssetsReadonly;

        public ContainerFlavor? ContainerFlavor;

        public Dictionary<string, string> CustomTags;

        public Dictionary<string, string> Metadata;

        [Obsolete("Use '' instead", false)] public bool? UseStreamingForAssetDownloads;

        public AzureVmSize? VmSize;
    }
}