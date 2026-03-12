using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateBuildWithCustomContainerResponse : PlayFabResultCommon
    {
        public string BuildId;

        public string BuildName;

        public string ContainerRunCommand;

        public ContainerImageReference CustomGameContainerImage;

        public List<AssetReference> GameAssetReferences;

        public List<GameCertificateReference> GameCertificateReferences;

        public LinuxInstrumentationConfiguration LinuxInstrumentationConfiguration;

        public MonitoringApplicationConfiguration MonitoringApplicationConfiguration;

        public int MultiplayerServerCountPerVm;

        public string OsPlatform;

        public List<Port> Ports;

        public List<BuildRegion> RegionConfigurations;

        public ServerResourceConstraintParams ServerResourceConstraints;

        public string ServerType;

        public VmStartupScriptConfiguration VmStartupScriptConfiguration;
        public bool? AreAssetsReadonly;

        public ContainerFlavor? ContainerFlavor;

        public DateTime? CreationTime;

        public Dictionary<string, string> Metadata;

        public bool? UseStreamingForAssetDownloads;

        public AzureVmSize? VmSize;
    }
}