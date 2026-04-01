using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class NameIdentifier : PlayFabBaseModel
    {
        public string Id;

        public string Name;
    }
}