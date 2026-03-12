using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class BlockEntityRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public EntityKey Group;
        public Dictionary<string, string> CustomTags;
    }
}