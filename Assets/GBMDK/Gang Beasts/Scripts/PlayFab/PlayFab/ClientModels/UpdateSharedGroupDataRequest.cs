using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class UpdateSharedGroupDataRequest : PlayFabRequestCommon
    {
        public List<string> KeysToRemove;

        public string SharedGroupId;
        public Dictionary<string, string> CustomTags;

        public Dictionary<string, string> Data;

        public UserDataPermission? Permission;
    }
}