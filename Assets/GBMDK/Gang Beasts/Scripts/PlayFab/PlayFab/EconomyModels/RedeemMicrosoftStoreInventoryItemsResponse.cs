using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class RedeemMicrosoftStoreInventoryItemsResponse : PlayFabResultCommon
    {
        public List<RedemptionFailure> Failed;

        public List<RedemptionSuccess> Succeeded;

        public List<string> TransactionIds;
    }
}