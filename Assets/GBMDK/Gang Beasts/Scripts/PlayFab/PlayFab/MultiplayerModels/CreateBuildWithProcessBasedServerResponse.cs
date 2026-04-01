using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class CreateBuildWithProcessBasedServerResponse : PlayFabResultCommon
    {
        public string BuildId;

        public string BuildName;

        public List<AssetReference> GameAssetReferences;

        public List<GameCertificateReference> GameCertificateReferences;

        public string GameWorkingDirectory;

        public InstrumentationConfiguration InstrumentationConfiguration;

        public MonitoringApplicationConfiguration MonitoringApplicationConfiguration;

        public int MultiplayerServerCountPerVm;

        public string OsPlatform;

        public List<Port> Ports;

        public List<BuildRegion> RegionConfigurations;

        public string ServerType;

        public string StartMultiplayerServerCommand;

        public VmStartupScriptConfiguration VmStartupScriptConfiguration;
        public bool? AreAssetsReadonly;

        public ContainerFlavor? ContainerFlavor;

        public DateTime? CreationTime;

        public bool? IsOSPreview;

        public Dictionary<string, string> Metadata;

        public bool? UseStreamingForAssetDownloads;

        public AzureVmSize? VmSize;
    }
}