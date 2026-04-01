using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class GetTransactionHistoryResponse : PlayFabResultCommon
    {
        public string ContinuationToken;

        public List<Transaction> Transactions;
    }
}