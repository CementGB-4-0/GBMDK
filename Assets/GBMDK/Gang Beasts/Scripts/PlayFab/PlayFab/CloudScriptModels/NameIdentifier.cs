using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
    [Serializable]
    public class NameIdentifier : PlayFabBaseModel
    {
        public string Id;

        public string Name;
    }
}