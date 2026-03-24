using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
    [Serializable]
    public class SetIntersectionRule : PlayFabBaseModel
    {
        public QueueRuleAttribute Attribute;

        public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior;

        public CustomSetIntersectionRuleExpansion CustomExpansion;

        public List<string> DefaultAttributeValue;

        public LinearSetIntersectionRuleExpansion LinearExpansion;

        public uint MinIntersectionSize;

        public string Name;

        public double Weight;

        public uint? SecondsUntilOptional;
    }
}