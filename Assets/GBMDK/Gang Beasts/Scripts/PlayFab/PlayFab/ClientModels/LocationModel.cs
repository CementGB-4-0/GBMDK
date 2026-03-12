using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class LocationModel : PlayFabBaseModel
    {
        public string City;

        public ContinentCode? ContinentCode;

        public CountryCode? CountryCode;

        public double? Latitude;

        public double? Longitude;
    }
}