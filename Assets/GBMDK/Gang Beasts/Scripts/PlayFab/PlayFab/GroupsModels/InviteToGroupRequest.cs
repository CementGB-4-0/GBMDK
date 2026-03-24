using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class InviteToGroupRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public EntityKey Group;

        public string RoleId;
        public bool? AutoAcceptOutstandingApplication;

        public Dictionary<string, string> CustomTags;
    }
}