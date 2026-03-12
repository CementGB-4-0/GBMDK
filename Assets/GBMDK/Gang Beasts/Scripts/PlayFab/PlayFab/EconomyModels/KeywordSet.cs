using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class KeywordSet : PlayFabBaseModel
    {
        public List<string> Values;
    }
}