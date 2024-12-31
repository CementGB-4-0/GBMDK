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

		public DateTime? CancelledAt;

		public DateTime? FilledAt;

		public DateTime? InvalidatedAt;

		public List<string> OfferedCatalogItemIds;

		public List<string> OfferedInventoryInstanceIds;

		public string OfferingPlayerId;

		public DateTime? OpenedAt;

		public List<string> RequestedCatalogItemIds;

		public TradeStatus? Status;

		public string TradeId;
	}
}
