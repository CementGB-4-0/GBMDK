using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class ContainerImageReference : PlayFabBaseModel
    {
        public string ImageName;

        public string Tag;
    }
}