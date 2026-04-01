using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
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