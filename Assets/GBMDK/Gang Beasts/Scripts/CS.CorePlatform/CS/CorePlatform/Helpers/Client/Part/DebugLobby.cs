using System;
using System.Collections.Generic;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform.Helpers.Client.Part
{
    internal class DebugLobby : MonoBehaviour
    {
        private Guid _id;
        private bool _inLobby;

        private bool _JoiningLobby;

        private bool _leavingLobby;

        private Dictionary<string, string> _LobbyData;

        private BasePlatformManager _Manager;

        private bool _WantsNewLobby;

        public ILobbyID CurrentLobbyID => null;

        public bool IsInLobby => false;

        public bool IsLobbyHost => false;

        public bool IsJoiningLobby => false;

        public int TotalInLobby => 0;

        public void Awake()
        {
        }

        public void CreateLobby()
        {
        }

        public void LeaveLobby()
        {
        }

        public bool GetLobbyData(string dataKey, out string dataOut)
        {
            dataOut = null;
            return false;
        }

        public bool SetLobbyData(string dataKey, string dataIn)
        {
            return false;
        }

        public void SendLobbyData()
        {
        }

        public bool GetLobbyInfo(ref LobbyInformation lobbyInfo)
        {
            return false;
        }

        public bool GetLobbyUser(int index, ref BaseUserInfo userData)
        {
            return false;
        }

        public bool GetLobbyUser(OnlineID id, ref BaseUserInfo userData)
        {
            return false;
        }

        public Texture2D GetLobbyUserImage(BaseUserInfo info)
        {
            return null;
        }

        public bool SendLobbyMessage(BaseUserInfo userInfo, PlatformMessageBase message)
        {
            return false;
        }

        public bool SendLobbyMessage(PlatformMessageBase message)
        {
            return false;
        }

        public bool UserIsInLobby(BaseUserInfo user)
        {
            return false;
        }

        public bool UserIsLobbyHost(BaseUserInfo user)
        {
            return false;
        }
    }
}