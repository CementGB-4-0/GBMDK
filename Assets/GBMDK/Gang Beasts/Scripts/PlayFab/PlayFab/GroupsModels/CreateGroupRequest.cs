using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class CreateGroupRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public string GroupName;
        public Dictionary<string, string> CustomTags;
    }
}