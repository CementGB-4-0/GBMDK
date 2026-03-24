using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GameCertificateReference : PlayFabBaseModel
    {
        public string GsdkAlias;

        public string Name;
    }
}