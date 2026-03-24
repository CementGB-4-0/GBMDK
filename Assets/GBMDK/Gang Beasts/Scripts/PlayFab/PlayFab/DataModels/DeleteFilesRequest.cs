using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class DeleteFilesRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public List<string> FileNames;
        public Dictionary<string, string> CustomTags;

        public int? ProfileVersion;
    }
}