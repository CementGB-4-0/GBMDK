using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class Image : PlayFabBaseModel
    {
        public string Id;

        public string Tag;

        public string Type;

        public string Url;
    }
}