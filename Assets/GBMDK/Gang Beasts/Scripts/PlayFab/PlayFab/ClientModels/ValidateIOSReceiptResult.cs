using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ValidateIOSReceiptResult : PlayFabResultCommon
    {
        public List<PurchaseReceiptFulfillment> Fulfillments;
    }
}