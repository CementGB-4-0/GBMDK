using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class Content : PlayFabBaseModel
    {
        public string Id;

        public string MaxClientVersion;

        public string MinClientVersion;

        public List<string> Tags;

        public string Type;

        public string Url;
    }
}