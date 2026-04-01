using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GetBuildResponse : PlayFabResultCommon
    {
        public string BuildId;

        public string BuildName;

        public string BuildStatus;

        public string ContainerRunCommand;

        public ContainerImageReference CustomGameContainerImage;

        public List<AssetReference> GameAssetReferences;

        public List<GameCertificateReference> GameCertificateReferences;

        public InstrumentationConfiguration InstrumentationConfiguration;

        public int MultiplayerServerCountPerVm;

        public string OsPlatform;

        public List<Port> Ports;

        public List<BuildRegion> RegionConfigurations;

        public ServerResourceConstraintParams ServerResourceConstraints;

        public string ServerType;

        public string StartMultiplayerServerCommand;

        public VmStartupScriptConfiguration VmStartupScriptConfiguration;
        public bool? AreAssetsReadonly;

        public ContainerFlavor? ContainerFlavor;

        public DateTime? CreationTime;

        public Dictionary<string, string> Metadata;

        public AzureVmSize? VmSize;
    }
}