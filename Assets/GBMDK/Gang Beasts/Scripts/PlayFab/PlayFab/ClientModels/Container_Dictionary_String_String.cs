using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class Container_Dictionary_String_String : PlayFabBaseModel
    {
        public Dictionary<string, string> Data;
    }
}