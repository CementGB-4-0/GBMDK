using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class TradeInfo : PlayFabBaseModel
    {
        public List<string> AcceptedInventoryInstanceIds;

        public string AcceptedPlayerId;

        public List<string> AllowedPlayerIds;

        public List<string> OfferedCatalogItemIds;

        public List<string> OfferedInventoryInstanceIds;

        public string OfferingPlayerId;

        public List<string> RequestedCatalogItemIds;

        public string TradeId;

        public DateTime? CancelledAt;

        public DateTime? FilledAt;

        public DateTime? InvalidatedAt;

        public DateTime? OpenedAt;

        public TradeStatus? Status;
    }
}