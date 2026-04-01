using System;

namespace Steamworks
{
    internal static class CSteamAPIContext
    {
        private static IntPtr m_pSteamClient;

        private static IntPtr m_pSteamUser;

        private static IntPtr m_pSteamFriends;

        private static IntPtr m_pSteamUtils;

        private static IntPtr m_pSteamMatchmaking;

        private static IntPtr m_pSteamUserStats;

        private static IntPtr m_pSteamApps;

        private static IntPtr m_pSteamMatchmakingServers;

        private static IntPtr m_pSteamNetworking;

        private static IntPtr m_pSteamRemoteStorage;

        private static IntPtr m_pSteamScreenshots;

        private static IntPtr m_pSteamGameSearch;

        private static IntPtr m_pSteamHTTP;

        private static IntPtr m_pController;

        private static IntPtr m_pSteamUGC;

        private static IntPtr m_pSteamAppList;

        private static IntPtr m_pSteamMusic;

        private static IntPtr m_pSteamMusicRemote;

        private static IntPtr m_pSteamHTMLSurface;

        private static IntPtr m_pSteamInventory;

        private static IntPtr m_pSteamVideo;

        private static IntPtr m_pSteamParentalSettings;

        private static IntPtr m_pSteamInput;

        private static IntPtr m_pSteamParties;

        private static IntPtr m_pSteamRemotePlay;

        private static IntPtr m_pSteamNetworkingUtils;

        private static IntPtr m_pSteamNetworkingSockets;

        private static IntPtr m_pSteamNetworkingMessages;

        internal static void Clear()
        {
        }

        internal static bool Init()
        {
            return false;
        }

        internal static IntPtr GetSteamClient()
        {
            return (IntPtr)0;
        }

        internal static IntPtr GetSteamUser()
        {
            return (IntPtr)0;
        }

        internal static IntPtr GetSteamFriends()
        {
            return (IntPtr)0;
        }

        internal static IntPtr GetSteamUtils()
        {
            return (IntPtr)0;
        }

        internal static IntPtr GetSteamUserStats()
        {
            return (IntPtr)0;
        }

        internal static IntPtr GetSteamApps()
        {
            return (IntPtr)0;
        }

        internal static IntPtr GetSteamRemoteStorage()
        {
            return (IntPtr)0;
        }
    }
}