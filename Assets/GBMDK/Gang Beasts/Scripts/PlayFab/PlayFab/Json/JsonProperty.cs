using System;

namespace PlayFab.Json
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class JsonProperty : Attribute
    {
        public NullValueHandling NullValueHandling;
        public string PropertyName;
    }
}