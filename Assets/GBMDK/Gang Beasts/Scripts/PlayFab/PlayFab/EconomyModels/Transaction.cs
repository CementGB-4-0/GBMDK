using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class Transaction : PlayFabBaseModel
    {
        public string ApiName;

        public string ItemType;

        public List<TransactionOperation> Operations;

        public string OperationType;

        public TransactionPurchaseDetails PurchaseDetails;

        public TransactionRedeemDetails RedeemDetails;

        public string TransactionId;

        public TransactionTransferDetails TransferDetails;

        public DateTime Timestamp;
    }
}