using System;
using System.Runtime.CompilerServices;
using CS.CorePlatform.Utils.Data;
using UnityEngine;

namespace CS.CorePlatform
{
    public static class PlatformEvents
    {
        public delegate void PlatformBoolEventDel(bool effect);

        public delegate void PlatformErrorCodesEventDel(ErrorCode value);

        public delegate void PlatformJoinEventDel(string IP, int port, string password);

        public delegate void PlatformMessageEventDel(DataReader message);

        public delegate void PlatformUserBoolEventDel(BaseUserInfo info, bool effect);

        public delegate void PlatformUserChangeEventDel(int slot, int localuserID, bool joined);

        public delegate void PlatformUserEventDel(BaseUserInfo info);

        public delegate void PlatformUserMessageEventDel(BaseUserInfo user, DataReader message);

        public delegate void PlatformVoidEventDel();

        public static event PlatformVoidEventDel OnGameSetup
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnOnlineConnectionLost
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyJoinedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyLeftEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyHostEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnSaveLocalStartedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnSaveLocalCompleteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLoadLocalStartedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLoadLocalCompleteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnReceivedGameInviteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnUsedGameInviteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnReceivedLobbyInviteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnUsedLobbyInviteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyDataUpdatedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<int> OnOnlineCheckStartedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<int, TryOnlineResult> OnOnlineCheckCompleteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyJoiningEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyCreatingEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnLobbyLeavingEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnPlatformInitializedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnSystemWaking
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformJoinEventDel OnJoinGameEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserEventDel OnUserPictureLoadedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserEventDel OnLobbyUserJoinedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserEventDel OnLobbyUserLeftEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserEventDel OnLobbyNewHostEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserBoolEventDel OnVoiceActiveStateChangedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserBoolEventDel OnVoiceMuteStateChangedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformBoolEventDel OnPlatformGamePauseEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformBoolEventDel OnPlatformGameSleepEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<bool, int> OnVoiceMicChangeEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformBoolEventDel OnVoiceEnabledStateChangedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformBoolEventDel OnEntitlementChangedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<bool> OnSaveLoadFailEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformMessageEventDel OnReceivedLobbyHostMessageEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserMessageEventDel OnReceivedLobbyClientMessageEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserMessageEventDel OnReceivedLobbyUserMessageEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserMessageEventDel OnReceivedUserMessageEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformErrorCodesEventDel OnLobbyCreationFailedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformErrorCodesEventDel OnLobbyJoiningFailedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserChangeEventDel OnLocalUserChanged
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformUserChangeEventDel OnOnlineAllowedChangeEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformBoolEventDel OnMainUserStateEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnMainUserClearedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event PlatformVoidEventDel OnPlatformLoadUnblockedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<BaseUserInfo[]> OnFriendsListUpdatedEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<string[]> OnSaveLocalFilesCompleteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<string[]> OnLoadLocalFilesCompleteEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<string, byte[]> OnOffMainThreadDataLoaded
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action OnDLCUpdated
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static event Action<byte[], int> OnSendServerInfoUpdate
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void ResetStatics()
        {
        }

        public static void GameSetup()
        {
        }

        public static void OnlineConnectionLost()
        {
        }

        public static void LobbyJoined()
        {
        }

        public static void LobbyLeft()
        {
        }

        public static void LobbyHost()
        {
        }

        public static void SaveLocalStarted()
        {
        }

        public static void SaveLocalComplete()
        {
        }

        public static void LoadLocalStarted()
        {
        }

        public static void LoadLocalComplete()
        {
        }

        public static void ReceivedGameInvite()
        {
        }

        public static void UsedGameInviteEvent()
        {
        }

        public static void ReceivedLobbyInvite()
        {
        }

        public static void UsedLobbyInviteEvent()
        {
        }

        public static void LobbyDataUpdated()
        {
        }

        public static void OnlineCheckStarted(int controller)
        {
        }

        public static void OnlineCheckComplete(int controller, TryOnlineResult result)
        {
        }

        public static void LobbyJoining()
        {
        }

        public static void LobbyCreating()
        {
        }

        public static void LobbyLeaving()
        {
        }

        public static void PlatformInitialized()
        {
        }

        public static void SystemWake()
        {
        }

        public static void JoinGame(string IP, int port, string password)
        {
        }

        public static void UserPictureLoaded(BaseUserInfo info)
        {
        }

        public static void LobbyUserJoined(BaseUserInfo info)
        {
        }

        public static void LobbyUserLeft(BaseUserInfo info)
        {
        }

        public static void LobbyNewHost(BaseUserInfo info)
        {
        }

        public static void VoiceActiveStateChanged(BaseUserInfo info, bool active)
        {
        }

        public static void VoiceMuteStateChanged(BaseUserInfo info, bool mute)
        {
        }

        public static void PlatformGamePause(bool on)
        {
        }

        public static void PlatformGameSleep(bool on)
        {
        }

        public static void VoiceMicChange(bool allowed, int controller)
        {
        }

        public static void VoiceEnabledStateChanged(bool active)
        {
        }

        public static void EntitlementChanged(bool passed)
        {
        }

        public static void SaveLoadFail(bool save)
        {
        }

        public static void ReceivedLobbyHostMessage(DataReader message)
        {
        }

        public static void ReceivedLobbyClientMessage(BaseUserInfo user, DataReader message)
        {
        }

        public static void ReceivedLobbyUserMessage(BaseUserInfo user, DataReader message)
        {
        }

        public static void ReceivedUserMessage(BaseUserInfo user, DataReader message)
        {
        }

        public static void LobbyCreationFailed(ErrorCode errorCode)
        {
        }

        public static void LobbyJoiningFailed(ErrorCode errorCode)
        {
        }

        public static void LocalUserChanged(int slot, int user, bool joined)
        {
        }

        public static void OnlineAllowedChange(int slot, int localuserID, bool allowed)
        {
        }

        public static void MainUserState(bool joined)
        {
        }

        public static void MainUserCleared()
        {
        }

        public static void PlatformLoadUnblocked()
        {
        }

        public static void FriendsListUpdated(BaseUserInfo[] newList)
        {
        }

        public static void SaveLocalFilesCompleteEvent(string[] files)
        {
        }

        public static void LoadLocalFilesComplete(string[] files)
        {
        }

        public static void OffMainThreadDataLoaded(string file, byte[] data)
        {
        }

        public static void DLCUpdated()
        {
        }

        public static void SendServerInfoUpdate(byte[] data, int size)
        {
        }

        public static void FlushEvents()
        {
        }
    }
}