using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class ListMembershipOpportunitiesRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;
        public Dictionary<string, string> CustomTags;
    }
}