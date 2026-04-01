using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class RedeemCouponRequest : PlayFabRequestCommon
    {
        public string CatalogVersion;

        public string CharacterId;

        public string CouponCode;

        public Dictionary<string, string> CustomTags;
    }
}