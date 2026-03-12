using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using CS.CorePlatform.Server;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform
{
    public abstract class BasePlatformManager : MonoBehaviour
    {
        protected static BasePlatformManager _Instance;

        private static bool _Initialized;

        protected static bool _InitializedPlatformAPI;

        private static bool _gameSetup;

        private static bool _running2D;

        protected static object _entitlementLock;

        protected static bool _entitlementChecked;

        protected static bool _userIsEntitled;

        private Action _blockerFreeCall;

        private List<string> _blockers;

        protected bool _crossplayEnabled;
        protected object _lockSend;

        public BasePlatformManager()
        {
        }

        public PlatformKeys Key => default(PlatformKeys);

        public static BasePlatformManager Instance
        {
            get { return null; }
            protected set { }
        }

        public static bool Initialized
        {
            get { return false; }
            protected set { }
        }

        public static bool GameSetup => false;

        public static bool IsRunning2D
        {
            get { return false; }
            set { }
        }

        public bool IsLoadBlocked => false;

        public virtual int MainUserID => 0;

        public static bool EntitlementChecked => false;

        public static bool HasEntitlement => false;

        public virtual bool StorageDisabled
        {
            get { return false; }
            set { }
        }

        public virtual bool IsLocalSaving => false;

        public virtual bool IsLocalLoading => false;

        public virtual OnlineID GetUserID => default(OnlineID);

        public virtual bool DynamicUsers => false;

        public virtual ILobbyID CurrentLobbyID => null;

        public virtual bool IsInLobby => false;

        public virtual bool IsLobbyHost => false;

        public virtual bool IsJoiningLobby => false;

        public virtual bool IsJoinable
        {
            get { return false; }
            set { }
        }

        public virtual bool IsLAN
        {
            get { return false; }
            set { }
        }

        public virtual int TotalInLobby => 0;

        public virtual bool HasLobbyInvite => false;

        public virtual string LobbyInviteHostName => null;

        public virtual bool VoiceEnabled
        {
            get { return false; }
            set { }
        }

        public virtual float DefaultVoiceVolume
        {
            get { return 0f; }
            set { }
        }

        public virtual bool DefaultVoiceMute
        {
            get { return false; }
            set { }
        }

        public virtual bool MainUserSignedIn => false;

        public virtual int MaxLocalPlayers => 0;

        public virtual bool GUIActive => false;

        public virtual bool IsOnlineAllowed => false;

        public virtual int MainController => 0;

        public virtual BaseUserInfo[] FriendsList => null;

        public void Update()
        {
        }

        private void OnDestroy()
        {
        }

        private void OnApplicationQuit()
        {
        }

        private event Action _CallNextUpdate
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        private event Action _CallThisUpdate
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event Action OnPreGameStart
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public void AddToNextUpdate(Action doThisNextUpdate)
        {
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void StartGame()
        {
        }

        public static void StopGame()
        {
        }

        public void AddBlocker(string key)
        {
        }

        public void RemoveBlocker(string key)
        {
        }

        private void RecheckBlockComplete()
        {
        }

        public abstract PlatformKeys GetKey();

        public abstract BaseUserInfo GetUserBaseInfo();

        public virtual void Shutdown()
        {
        }

        public virtual void PlatformUpdate()
        {
        }

        public void FailEntitlement()
        {
        }

        public void PassEntitlement()
        {
        }

        public virtual string[] Loaded()
        {
            return null;
        }

        public virtual int Loaded(string file)
        {
            return 0;
        }

        public virtual int Load(string file, ref byte[] data, bool copy = false, bool safe = true)
        {
            return 0;
        }

        public virtual int Load(string file, ref string data, bool safe = true)
        {
            return 0;
        }

        public virtual bool Save(string file, byte[] data, int size, bool copy = false, bool safe = true)
        {
            return false;
        }

        public virtual bool Save(string file, string data, bool safe = true)
        {
            return false;
        }

        public virtual void SendSavedData()
        {
        }

        public virtual void LoadSavedData(string[] files)
        {
        }

        public virtual void ForgetFile(string file)
        {
        }

        public virtual bool HasDLC(string dlcKey)
        {
            return false;
        }

        public bool HasDLC(string[] dlcKeys)
        {
            return false;
        }

        public bool HasDLC(List<string> dlcKeys)
        {
            return false;
        }

        public virtual void ShowDLCStore(string dlcKey)
        {
        }

        public virtual string GetUserName()
        {
            return null;
        }

        public virtual string GetUserName(int controller)
        {
            return null;
        }

        public virtual OnlineID GetUserOnlineID(int controller)
        {
            return default(OnlineID);
        }

        public virtual void OpenUserProfile(BaseUserInfo userInfo)
        {
        }

        public virtual bool UserJoined(int controller)
        {
            return false;
        }

        public virtual void UserLeave(int controller)
        {
        }

        public virtual void ClearMainUser()
        {
        }

        public virtual void SetRichPresenceDetails(string presenceKey = null, string[] parameter = null)
        {
        }

        public virtual void SetRichPresenceStatus(string statusKey = null)
        {
        }

        public virtual void SetRichPresenceLargeImage(string imageKey = null)
        {
        }

        public virtual void SetRichPresenceSmallImage(string imageKey = null)
        {
        }

        public void ClearPresence()
        {
        }

        public virtual void SendRichPresence()
        {
        }

        public virtual void UnlockAchievement(string achievementName)
        {
        }

        public virtual bool IsAchievementUnlocked(string achievementName)
        {
            return false;
        }

        public bool IsAchievementUnlocked(string[] achievementNames)
        {
            return false;
        }

        public bool IsAchievementUnlocked(List<string> achievementNames)
        {
            return false;
        }

        public virtual void IncrementStatistic(string statisticName, float amount)
        {
        }

        public virtual void SetStatistic(string statisticName, float value)
        {
        }

        public virtual float GetStatistic(string statisticName)
        {
            return 0f;
        }

        public virtual void ShowWebsite(string address)
        {
        }

        public virtual void ShowGameStore()
        {
        }

        public virtual void ShowGameForum()
        {
        }

        public virtual void ShowGameSupport()
        {
        }

        public virtual void CreateLobby(LOBBY_TYPE lobbyType, uint maxSlots)
        {
        }

        public virtual void LeaveLobby()
        {
        }

        public virtual void JoinLobby(ILobbyID id)
        {
        }

        public virtual void JoinLobbyViaCode(string joinCode)
        {
        }

        public virtual void GatherLobbies(ref List<LobbyInformation> info)
        {
        }

        public virtual bool GetLobbyData(string dataKey, out string dataOut)
        {
            dataOut = null;
            return false;
        }

        public virtual bool SetLobbyData(string dataKey, string dataIn)
        {
            return false;
        }

        public virtual void SendLobbyData()
        {
        }

        public virtual BaseUserInfo LobbyHost()
        {
            return default(BaseUserInfo);
        }

        public virtual bool GetLobbyInfo(ref LobbyInformation lobbyInfo)
        {
            return false;
        }

        public virtual bool GetLobbyUser(OnlineID userID, ref BaseUserInfo userData)
        {
            return false;
        }

        public virtual bool LobbyKickUser(BaseUserInfo info)
        {
            return false;
        }

        public virtual bool JoinInviteLobby()
        {
            return false;
        }

        public virtual bool ShowPlatformLobbyMenu()
        {
            return false;
        }

        public virtual bool SendLobbyMessage(BaseUserInfo userInfo, PlatformMessageBase message)
        {
            return false;
        }

        public virtual bool SendLobbyMessage(PlatformMessageBase message)
        {
            return false;
        }

        public virtual bool UserIsInLobby(BaseUserInfo user)
        {
            return false;
        }

        public virtual bool UserIsLobbyHost(BaseUserInfo user)
        {
            return false;
        }

        public virtual bool InviteUserToLobby(BaseUserInfo user)
        {
            return false;
        }

        public virtual void AddVoiceConnection(BaseUserInfo userInfo)
        {
        }

        public virtual void RemoveVoiceConnection(BaseUserInfo userInfo)
        {
        }

        public virtual void ClearVoiceConectionsClear()
        {
        }

        public virtual bool MicPresent(int controller)
        {
            return false;
        }

        public virtual bool VoiceActive(int controller)
        {
            return false;
        }

        public virtual void StartVoice(int controller)
        {
        }

        public virtual void StopVoice(int controller)
        {
        }

        public virtual void SetVoiceMuted(BaseUserInfo userInfo, bool mute)
        {
        }

        public virtual bool GetVoiceMuted(BaseUserInfo userInfo)
        {
            return false;
        }

        public virtual void SetVoiceMutes(bool mute)
        {
        }

        public virtual void SetVoiceVolumes(float volume)
        {
        }

        public virtual float GetVoiceVolume(BaseUserInfo userInfo)
        {
            return 0f;
        }

        public virtual void SetVoiceVolume(BaseUserInfo userInfo, float volume)
        {
        }

        public virtual bool SetToLocalUserImage(int localID, ref Texture2D terxtureSetting)
        {
            return false;
        }

        public virtual bool SetToUserImage(BaseUserInfo userInfo, ref Texture2D terxtureSetting)
        {
            return false;
        }

        public virtual void JoinGameServer(ServerInfo info)
        {
        }

        public virtual void UpdateGameServer(ServerInfo info)
        {
        }

        public virtual void SetPlayedWith(BaseUserInfo userInfo)
        {
        }

        public virtual void LeftGameServer()
        {
        }

        public virtual bool SendMessage(BaseUserInfo userInfo, PlatformMessageBase message, bool reliable)
        {
            return false;
        }

        public virtual void MessageStartConnecting(BaseUserInfo userInfo)
        {
        }

        public virtual void MessageDiconnect(BaseUserInfo userInfo)
        {
        }

        public virtual void MessageDiconnectAll()
        {
        }

        public virtual bool SetControllerColour(int controllerID, Color colour)
        {
            return false;
        }

        public virtual int UserLocalID(int controlller)
        {
            return 0;
        }

        public virtual bool ShowSystemMessageYESNO(string body, Action yesAction, Action noAction,
            string yesMessage = null, string noMessage = null)
        {
            return false;
        }

        public virtual bool ShowSystemMessageOK(string body, Action action, string okMessage = null)
        {
            return false;
        }

        public virtual void UpdateOnlinePermistion(int controller = -1)
        {
        }

        public virtual TryOnlineResult TryToGoOnline(bool showMessage)
        {
            return default(TryOnlineResult);
        }

        public virtual TryOnlineResult TryToGoOnline(int controller, bool showMessage)
        {
            return default(TryOnlineResult);
        }

        public virtual bool ShowOnlineFailReason(int controller)
        {
            return false;
        }

        public virtual void OnlineUpdate()
        {
        }

        public virtual bool UserActive(int controlller)
        {
            return false;
        }

        public virtual void SetOnlineState(int controller, bool active)
        {
        }

        public virtual bool RequestNetwork()
        {
            return false;
        }

        public virtual bool IsNetworkRequestInProgress()
        {
            return false;
        }

        public virtual bool IsNetworkAvailable()
        {
            return false;
        }

        public virtual bool IsLocalWirelessNetworkAvailable()
        {
            return false;
        }

        public virtual void ResetNetworkSettings(Action f)
        {
        }

        public virtual void ShutdownNetwork()
        {
        }

        public bool IsCrossplayEnabled()
        {
            return false;
        }

        public void SetCrossplayEnabled(bool value)
        {
        }

        public virtual bool UpdateFriendsList()
        {
            return false;
        }
    }
}