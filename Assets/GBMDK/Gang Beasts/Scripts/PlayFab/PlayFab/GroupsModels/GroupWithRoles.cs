using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class GroupWithRoles : PlayFabBaseModel
    {
        public EntityKey Group;

        public string GroupName;

        public int ProfileVersion;

        public List<GroupRole> Roles;
    }
}