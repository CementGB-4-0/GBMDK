using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class IsMemberRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public EntityKey Group;

        public string RoleId;
        public Dictionary<string, string> CustomTags;
    }
}