using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class ApplyToGroupResponse : PlayFabResultCommon
    {
        public EntityWithLineage Entity;

        public EntityKey Group;

        public DateTime Expires;
    }
}