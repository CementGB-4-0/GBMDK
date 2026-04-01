using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class ListGroupInvitationsRequest : PlayFabRequestCommon
    {
        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}