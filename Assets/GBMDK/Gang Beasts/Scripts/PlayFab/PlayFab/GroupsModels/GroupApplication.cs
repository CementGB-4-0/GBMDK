using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class GroupApplication : PlayFabBaseModel
    {
        public EntityWithLineage Entity;

        public EntityKey Group;

        public DateTime Expires;
    }
}