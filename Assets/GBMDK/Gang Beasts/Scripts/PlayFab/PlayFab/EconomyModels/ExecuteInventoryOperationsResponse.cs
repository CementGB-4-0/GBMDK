using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class ExecuteInventoryOperationsResponse : PlayFabResultCommon
    {
        public string ETag;

        public string IdempotencyId;

        public List<string> TransactionIds;
    }
}