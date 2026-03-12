using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class GameCertificateReferenceParams : PlayFabBaseModel
    {
        public string GsdkAlias;

        public string Name;
    }
}