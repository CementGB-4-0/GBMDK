using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class TagModel : PlayFabBaseModel
    {
        public string TagValue;
    }
}