using System;
using System.Collections.Generic;
using Coatsink.Platform.Systems.Online;
using UnityEngine;
using UnityEngine.Networking;

namespace CS.CorePlatform.Utils
{
    public static class Lobby
    {
        public static string LobbyDataUpdateFlag;

        private static Dictionary<Type, Action<NetworkWriter, ILobbyID>> SerializeCalls;

        static Lobby()
        {
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        private static void SerializeGUID(NetworkWriter writer, ILobbyID serialize)
        {
        }

        private static void SerializeString(NetworkWriter writer, ILobbyID serialize)
        {
        }

        private static void SerializeLong(NetworkWriter writer, ILobbyID serialize)
        {
        }

        public static ILobbyID Deserialize(NetworkReader reader)
        {
            return null;
        }

        public static void Serialize(NetworkWriter writer, ILobbyID lobbyID)
        {
        }

        public static Guid UlongToGuid(ulong lobbyID)
        {
            return default(Guid);
        }

        public static ulong GuidToUlong(Guid lobbyID)
        {
            return 0uL;
        }

        public static string StringSerialize(ILobbyID lobbyID)
        {
            return null;
        }

        public static ILobbyID ReadStringLobby(string input, ref int start)
        {
            return null;
        }
    }
}