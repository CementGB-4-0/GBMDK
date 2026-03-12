using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class RemoveGroupInvitationRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}