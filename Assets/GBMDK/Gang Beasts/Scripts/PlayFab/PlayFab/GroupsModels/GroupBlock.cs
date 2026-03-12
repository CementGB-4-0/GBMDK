using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class GroupBlock : PlayFabBaseModel
    {
        public EntityWithLineage Entity;

        public EntityKey Group;
    }
}