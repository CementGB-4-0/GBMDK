using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class EntityProfileBody : PlayFabBaseModel
    {
        public string AvatarUrl;

        public string DisplayName;

        public EntityKey Entity;

        public string EntityChain;

        public List<string> ExperimentVariants;

        public string Language;

        public string LeaderboardMetadata;

        public EntityLineage Lineage;

        public List<EntityPermissionStatement> Permissions;

        public int VersionNumber;

        public DateTime Created;

        public Dictionary<string, EntityProfileFileMetadata> Files;

        public Dictionary<string, EntityDataObject> Objects;

        public Dictionary<string, EntityStatisticValue> Statistics;
    }
}