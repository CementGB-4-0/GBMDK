using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class DeleteGroupRequest : PlayFabRequestCommon
    {
        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}