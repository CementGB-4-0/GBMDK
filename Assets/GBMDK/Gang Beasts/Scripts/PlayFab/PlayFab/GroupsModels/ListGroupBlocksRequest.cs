using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class ListGroupBlocksRequest : PlayFabRequestCommon
    {
        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}