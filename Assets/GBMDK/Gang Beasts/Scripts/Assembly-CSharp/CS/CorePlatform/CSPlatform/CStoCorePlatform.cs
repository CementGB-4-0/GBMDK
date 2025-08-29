using System;
using CS.CorePlatform.Server;
using CS.CorePlatform.Utils;
using CS.CorePlatform.Utils.Data;
using Coatsink.Platform;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using Coatsink.Platform.Utils;
using UnityEngine;

namespace CS.CorePlatform.CSPlatform
{
	public class CStoCorePlatform : BasePlatformManager
	{
		public SystemFileLocker _lockFile;

		private PlatformSystemMessenger _dialogUI;

		private bool _lastPopup;

		private CSUserEvents _users;

		private CSOnline _online;

		private CSLoadCarrier _storage;

		public CSNetworkStatus _network;

		public CSPlayWith _playWith;

		private CSLocConverter _loc;

		public PlatformSystemMessenger Dialog => null;

		public CSUserEvents Users => null;

		public CSOnline Online => null;

		public CSLoadCarrier Storage => null;

		public CSNetworkStatus Network => null;

		public CSPlayWith PlayWith => null;

		public override int MainUserID => 0;

		public override bool MainUserSignedIn => false;

		public override int MainController => 0;

		public override OnlineID GetUserID => default(OnlineID);

		public override bool DynamicUsers => false;

		public override bool IsOnlineAllowed => false;

		public override bool StorageDisabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool IsLocalSaving => false;

		public override bool IsLocalLoading => false;

		public override bool GUIActive => false;

		public override int MaxLocalPlayers => 0;

		public override ILobbyID CurrentLobbyID => null;

		public override bool IsInLobby => false;

		public override bool IsLobbyHost => false;

		public override bool IsJoiningLobby => false;

		public override int TotalInLobby => 0;

		public override bool HasLobbyInvite => false;

		public override bool SetToUserImage(BaseUserInfo userInfo, ref Texture2D terxtureSetting)
		{
			return false;
		}

		public void Awake()
		{
		}

		public void OnDisable()
		{
		}

		public override void Shutdown()
		{
		}

		private void OnInitializeComplete(TaskResult<bool> obj)
		{
		}

		public override void PlatformUpdate()
		{
		}

		public override PlatformKeys GetKey()
		{
			return default(PlatformKeys);
		}

		public override BaseUserInfo GetUserBaseInfo()
		{
			return default(BaseUserInfo);
		}

		public override string GetUserName()
		{
			return null;
		}

		public override string GetUserName(int controller)
		{
			return null;
		}

		public override void OpenUserProfile(BaseUserInfo userInfo)
		{
		}

		public override int UserLocalID(int controller)
		{
			return 0;
		}

		public override bool UserJoined(int controller)
		{
			return false;
		}

		public override void UserLeave(int controller)
		{
		}

		public override void ClearMainUser()
		{
		}

		public override OnlineID GetUserOnlineID(int controller)
		{
			return default(OnlineID);
		}

		public override void UpdateOnlinePermistion(int controller = -1)
		{
		}

		public override TryOnlineResult TryToGoOnline(bool showMessage)
		{
			return default(TryOnlineResult);
		}

		public override TryOnlineResult TryToGoOnline(int controller, bool showMessage)
		{
			return default(TryOnlineResult);
		}

		public override bool ShowOnlineFailReason(int controller)
		{
			return false;
		}

		public override void UnlockAchievement(string achievementName)
		{
		}

		public override bool IsAchievementUnlocked(string achievementName)
		{
			return false;
		}

		public override string[] Loaded()
		{
			return null;
		}

		public override int Loaded(string file)
		{
			return 0;
		}

		public override int Load(string file, ref byte[] data, bool copy = true, bool safe = true)
		{
			return 0;
		}

		public override int Load(string file, ref string data, bool safe = true)
		{
			return 0;
		}

		public override bool Save(string file, byte[] data, int size, bool copy = false, bool safe = true)
		{
			return false;
		}

		public override bool Save(string file, string data, bool safe = true)
		{
			return false;
		}

		public override void SendSavedData()
		{
		}

		public override void LoadSavedData(string[] load)
		{
		}

		public override void ForgetFile(string file)
		{
		}

		private void CheckUIEvent(bool obj)
		{
		}

		public override bool ShowSystemMessageYESNO(string body, Action yesAction, Action noAction, string yesMessage = null, string noMessage = null)
		{
			return false;
		}

		public override bool ShowSystemMessageOK(string body, Action action, string okMessage = null)
		{
			return false;
		}

		public override bool SendMessage(BaseUserInfo userInfo, PlatformMessageBase message, bool reliable)
		{
			return false;
		}

		public override void CreateLobby(LOBBY_TYPE lobbyType, uint maxSlots)
		{
		}

		public override void LeaveLobby()
		{
		}

		public override void JoinLobby(ILobbyID id)
		{
		}

		public void JoinLobbyViaCode(string joinCode)
		{
		}

		public override bool GetLobbyInfo(ref LobbyInformation lobbyInfo)
		{
			return false;
		}

		public override bool GetLobbyUser(OnlineID userID, ref BaseUserInfo userData)
		{
			return false;
		}

		public override bool LobbyKickUser(BaseUserInfo info)
		{
			return false;
		}

		public override bool ShowPlatformLobbyMenu()
		{
			return false;
		}

		public override bool SendLobbyMessage(BaseUserInfo userInfo, PlatformMessageBase message)
		{
			return false;
		}

		public override bool SendLobbyMessage(PlatformMessageBase message)
		{
			return false;
		}

		public override bool UserIsInLobby(BaseUserInfo user)
		{
			return false;
		}

		public override bool UserIsLobbyHost(BaseUserInfo user)
		{
			return false;
		}

		public override BaseUserInfo LobbyHost()
		{
			return default(BaseUserInfo);
		}

		public override bool IsNetworkAvailable()
		{
			return false;
		}

		public override void JoinGameServer(ServerInfo info)
		{
		}

		public override void UpdateGameServer(ServerInfo info)
		{
		}

		public override void SetPlayedWith(BaseUserInfo userInfo)
		{
		}
	}
}
