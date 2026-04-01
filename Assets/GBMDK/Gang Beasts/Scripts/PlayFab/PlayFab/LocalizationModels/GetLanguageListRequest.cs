using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.LocalizationModels
{
    [Serializable]
    public class GetLanguageListRequest : PlayFabRequestCommon
    {
        public Dictionary<string, string> CustomTags;
    }
}