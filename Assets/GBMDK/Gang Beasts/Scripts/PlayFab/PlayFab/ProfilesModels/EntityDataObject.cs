using System;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class EntityDataObject : PlayFabBaseModel
    {
        public string EscapedDataObject;

        public string ObjectName;
        public object DataObject;
    }
}