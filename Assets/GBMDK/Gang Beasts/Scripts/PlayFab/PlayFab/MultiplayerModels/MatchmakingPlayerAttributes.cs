using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class MatchmakingPlayerAttributes : PlayFabBaseModel
    {
        public string EscapedDataObject;
        public object DataObject;
    }
}