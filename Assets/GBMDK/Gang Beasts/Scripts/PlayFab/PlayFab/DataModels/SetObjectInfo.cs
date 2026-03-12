using System;
using PlayFab.SharedModels;

namespace PlayFab.DataModels
{
    [Serializable]
    public class SetObjectInfo : PlayFabBaseModel
    {
        public string ObjectName;

        public string OperationReason;

        public OperationTypes? SetResult;
    }
}