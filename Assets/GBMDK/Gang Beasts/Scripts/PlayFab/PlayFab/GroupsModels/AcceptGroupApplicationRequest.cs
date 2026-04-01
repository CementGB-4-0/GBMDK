using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class AcceptGroupApplicationRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}