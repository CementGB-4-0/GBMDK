using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Utils.Data
{
    public class PlatformPresenceDatabase : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] public string StatusConnectionType;

        [SerializeField] private List<Presence> _serializerP;

        [SerializeField] private List<Status> _serializerS;

        [SerializeField] private List<Images> _serializerI;

        public Dictionary<string, Images> images;

        public Dictionary<string, Presence> presence;

        public Dictionary<string, Status> status;

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
        }

        public string GetSteamPresence(string key)
        {
            return null;
        }

        public string GetPS4Presence(string key)
        {
            return null;
        }

        public string GetDiscordPresence(string key)
        {
            return null;
        }

        public string GetXboxPresence(string key)
        {
            return null;
        }

        public string GetSteamStatus(string key)
        {
            return null;
        }

        public string GetPS4Status(string key)
        {
            return null;
        }

        public string GetDiscordStatus(string key)
        {
            return null;
        }

        public string GetDiscordImage(string key)
        {
            return null;
        }

        public string GetDiscordImageText(string key)
        {
            return null;
        }

        [Serializable]
        public class Presence
        {
            public string key;

            public string steamLocCode;

            public string discordLocCode;

            public string ps4LocCode;

            public string xboxKey;

            public Presence(string newKey)
            {
            }
        }

        [Serializable]
        public class Status
        {
            public string key;

            public string steamLocCode;

            public string discordLocCode;

            public string ps4LocCode;

            public Status(string newKey)
            {
            }
        }

        [Serializable]
        public class Images
        {
            public string key;

            public string discordCode;

            public string discordTextCode;

            public Images(string newKey)
            {
            }
        }
    }
}