using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class UpdateGroupRoleRequest : PlayFabRequestCommon
    {
        public EntityKey Group;

        public string RoleId;

        public string RoleName;
        public Dictionary<string, string> CustomTags;

        public int? ExpectedProfileVersion;
    }
}