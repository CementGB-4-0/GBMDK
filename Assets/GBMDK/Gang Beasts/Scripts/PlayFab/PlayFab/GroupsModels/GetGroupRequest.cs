using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class GetGroupRequest : PlayFabRequestCommon
    {
        public EntityKey Group;

        public string GroupName;
        public Dictionary<string, string> CustomTags;
    }
}