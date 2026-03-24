using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class SetProfileLanguageRequest : PlayFabRequestCommon
    {
        public EntityKey Entity;

        public string Language;
        public Dictionary<string, string> CustomTags;

        public int? ExpectedVersion;
    }
}