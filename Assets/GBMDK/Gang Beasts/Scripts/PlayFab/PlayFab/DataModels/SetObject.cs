using System;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class SetObject : PlayFabBaseModel
    {
        public string EscapedDataObject;

        public string ObjectName;
        public object DataObject;

        public bool? DeleteObject;
    }
}