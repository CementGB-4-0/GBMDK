using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class Rating : PlayFabBaseModel
    {
        public float? Average;

        public int? Count1Star;

        public int? Count2Star;

        public int? Count3Star;

        public int? Count4Star;

        public int? Count5Star;

        public int? TotalCount;
    }
}