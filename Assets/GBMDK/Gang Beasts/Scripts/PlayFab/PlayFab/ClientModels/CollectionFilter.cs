using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CollectionFilter : PlayFabBaseModel
    {
        public List<Container_Dictionary_String_String> Excludes;

        public List<Container_Dictionary_String_String> Includes;
    }
}