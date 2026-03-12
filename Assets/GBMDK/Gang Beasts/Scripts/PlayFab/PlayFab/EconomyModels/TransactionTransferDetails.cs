using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class TransactionTransferDetails : PlayFabBaseModel
    {
        public string GivingCollectionId;

        public EntityKey GivingEntity;

        public string ReceivingCollectionId;

        public EntityKey ReceivingEntity;

        public string TransferId;
    }
}