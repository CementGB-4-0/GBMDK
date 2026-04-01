using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class Variable : PlayFabBaseModel
    {
        public string Name;

        public string Value;
    }
}