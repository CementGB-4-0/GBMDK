using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
    public class SonyServiceDatabase : ScriptableObject
    {
        public const string DefaultSave = "Assets/Coatsink/Resources/Platform/SonyService.asset";

        [SerializeField] public bool onlineEnabled;

        [SerializeField] public bool dynamicUsers;

        [SerializeField] public List<PS4StorageInfo> Labels;

        [SerializeField] public int activeRegion;

        public void ActivatePS4(string region)
        {
        }

        public int GetRegionIndex(string region)
        {
            return 0;
        }

        public void RemoveRegion(string region)
        {
        }

        public static SonyServiceDatabase GetSonyServiceInfo(string databaseLocation = null)
        {
            return null;
        }

        [Serializable]
        public class PS4StorageInfo
        {
            public string region;

            public int Matching2;

            public int sessionInvitation;

            public int Presence;

            public int NpService;

            public PS4StorageInfo(string region)
            {
            }
        }
    }
}