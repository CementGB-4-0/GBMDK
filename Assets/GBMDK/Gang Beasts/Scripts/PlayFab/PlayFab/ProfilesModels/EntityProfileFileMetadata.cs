using System;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class EntityProfileFileMetadata : PlayFabBaseModel
    {
        public string Checksum;

        public string FileName;

        public int Size;

        public DateTime LastModified;
    }
}