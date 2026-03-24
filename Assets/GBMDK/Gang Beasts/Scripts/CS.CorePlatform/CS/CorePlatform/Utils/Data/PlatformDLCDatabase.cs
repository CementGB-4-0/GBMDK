using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
    public class PlatformDLCDatabase : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] private List<DLCInfo> _serializer;

        public Dictionary<string, DLCInfo> DLCs;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }

        public List<string> GetKeys()
        {
            return null;
        }

        public List<string> PS4Index(string key)
        {
            return null;
        }

        public uint SteamAPI(string key)
        {
            return 0u;
        }

        public string OculusAPI(string key)
        {
            return null;
        }

        public string Name(string key)
        {
            return null;
        }

        public string Description(string key)
        {
            return null;
        }

        public long DiscrodAPI(string key)
        {
            return 0L;
        }

        public ulong GogAPI(string key)
        {
            return 0uL;
        }

        public string XboxTitle(string key, out bool needsMount)
        {
            needsMount = default(bool);
            return null;
        }

        public bool XboxMount(string productID)
        {
            return false;
        }

        public int SwitchIndex(string key, out bool needsMount)
        {
            needsMount = default(bool);
            return 0;
        }

        public bool SwitchMount(int indexID)
        {
            return false;
        }

        [Serializable]
        public class DLCInfo
        {
            public string key;

            public string name;

            public string description;

            public List<string> ps4Index;

            public uint steamAPI;

            public string oculusAPI;

            public long discordAPI;

            public ulong gogAPI;

            public string xboxProductID;

            public bool xboxMount;

            public int switchIndex;

            public bool switchMount;

            public DLCInfo(string newKey)
            {
            }
        }
    }
}