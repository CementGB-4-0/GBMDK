using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EconomyModels
{
    [Serializable]
    public class CatalogConfig : PlayFabBaseModel
    {
        public List<EntityKey> AdminEntities;

        public CatalogSpecificConfig Catalog;

        public List<DeepLinkFormat> DeepLinkFormats;

        public List<DisplayPropertyIndexInfo> DisplayPropertyIndexInfos;

        public FileConfig File;

        public ImageConfig Image;

        public bool IsCatalogEnabled;

        public List<string> Platforms;

        public List<EntityKey> ReviewerEntities;

        public UserGeneratedContentSpecificConfig UserGeneratedContent;
    }
}