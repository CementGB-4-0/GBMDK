using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class UpdateGroupRequest : PlayFabRequestCommon
    {
        public string AdminRoleId;

        public EntityKey Group;

        public string GroupName;

        public string MemberRoleId;

        public Dictionary<string, string> CustomTags;

        public int? ExpectedProfileVersion;
    }
}