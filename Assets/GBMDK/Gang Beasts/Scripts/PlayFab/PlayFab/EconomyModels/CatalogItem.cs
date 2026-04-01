using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogItem : PlayFabBaseModel
    {
        public List<CatalogAlternateId> AlternateIds;

        public List<Content> Contents;

        public string ContentType;

        public EntityKey CreatorEntity;

        public List<DeepLink> DeepLinks;

        public string DefaultStackId;

        public string DisplayVersion;

        public string ETag;

        public string Id;

        public List<Image> Images;

        public List<CatalogItemReference> ItemReferences;

        public ModerationState Moderation;

        public List<string> Platforms;

        public CatalogPriceOptions PriceOptions;

        public Rating Rating;

        public StoreDetails StoreDetails;

        public List<string> Tags;

        public string Type;

        public DateTime? CreationDate;

        public Dictionary<string, string> Description;

        public object DisplayProperties;

        public DateTime? EndDate;

        public bool? IsHidden;

        public Dictionary<string, KeywordSet> Keywords;

        public DateTime? LastModifiedDate;

        public DateTime? StartDate;

        public Dictionary<string, string> Title;
    }
}