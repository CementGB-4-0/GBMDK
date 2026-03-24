using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class SetObjectsRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public List<SetObject> Objects;
        public Dictionary<string, string> CustomTags;

        public int? ExpectedProfileVersion;
    }
}