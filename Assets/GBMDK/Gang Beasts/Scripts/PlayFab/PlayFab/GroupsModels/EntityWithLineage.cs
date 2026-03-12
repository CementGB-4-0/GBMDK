using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class EntityWithLineage : PlayFabBaseModel
    {
        public EntityKey Key;

        public Dictionary<string, EntityKey> Lineage;
    }
}