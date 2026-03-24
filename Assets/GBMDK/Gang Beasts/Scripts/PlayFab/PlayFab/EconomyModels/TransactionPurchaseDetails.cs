using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class TransactionPurchaseDetails : PlayFabBaseModel
    {
        public string StoreId;
    }
}