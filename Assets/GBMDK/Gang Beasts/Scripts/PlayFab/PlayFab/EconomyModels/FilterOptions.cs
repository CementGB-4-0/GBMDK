using System;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class FilterOptions : PlayFabBaseModel
    {
        public string Filter;

        public bool? IncludeAllItems;
    }
}