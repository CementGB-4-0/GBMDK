using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class GetFilesRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;
        public Dictionary<string, string> CustomTags;
    }
}