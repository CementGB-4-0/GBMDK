using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class DeleteRoleRequest : PlayFabRequestCommon
    {
        public EntityKey Group;

        public string RoleId;
        public Dictionary<string, string> CustomTags;
    }
}