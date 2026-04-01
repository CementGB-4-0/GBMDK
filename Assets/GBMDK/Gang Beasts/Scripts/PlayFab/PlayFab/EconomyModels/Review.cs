using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class Review : PlayFabBaseModel
    {
        public int HelpfulNegative;

        public int HelpfulPositive;

        public bool IsInstalled;

        public string ItemId;

        public string ItemVersion;

        public string Locale;

        public int Rating;

        public EntityKey ReviewerEntity;

        public string ReviewerId;

        public string ReviewId;

        public string ReviewText;

        public string Title;

        public DateTime Submitted;
    }
}