using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class RegionInfo : PlayFabBaseModel
    {
        public bool Available;

        public string Name;

        public string PingUrl;

        public Region? Region;
    }
}