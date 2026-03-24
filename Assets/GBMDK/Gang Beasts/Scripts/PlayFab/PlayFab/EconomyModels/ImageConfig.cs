using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class ImageConfig : PlayFabBaseModel
    {
        public List<string> Tags;
    }
}