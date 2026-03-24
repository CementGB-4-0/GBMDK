using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class EntityMemberRole : PlayFabBaseModel
    {
        public List<EntityWithLineage> Members;

        public string RoleId;

        public string RoleName;
    }
}