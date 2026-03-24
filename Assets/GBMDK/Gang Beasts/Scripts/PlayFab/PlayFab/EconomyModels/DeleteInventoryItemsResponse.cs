using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class DeleteInventoryItemsResponse : PlayFabResultCommon
    {
        public string ETag;

        public string IdempotencyId;

        public List<string> TransactionIds;
    }
}