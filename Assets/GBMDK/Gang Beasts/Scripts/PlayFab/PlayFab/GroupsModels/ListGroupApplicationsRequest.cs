using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class ListGroupApplicationsRequest : PlayFabRequestCommon
    {
        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}