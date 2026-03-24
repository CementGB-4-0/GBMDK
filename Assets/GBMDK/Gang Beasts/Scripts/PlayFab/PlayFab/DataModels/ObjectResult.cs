using System;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class ObjectResult : PlayFabBaseModel
    {
        public string EscapedDataObject;

        public string ObjectName;
        public object DataObject;
    }
}