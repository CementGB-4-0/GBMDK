using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class ReviewTakedown : PlayFabBaseModel
    {
        public CatalogAlternateId AlternateId;

        public string ItemId;

        public string ReviewId;
    }
}