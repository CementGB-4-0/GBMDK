using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	internal static class NativeMethods
	{
		[PreserveSig]
		public static extern bool SteamAPI_Init();

		[PreserveSig]
		public static extern void SteamAPI_Shutdown();

		[PreserveSig]
		public static extern bool SteamAPI_RestartAppIfNecessary(AppId_t unOwnAppID);

		[PreserveSig]
		public static extern bool SteamAPI_IsSteamRunning();

		[PreserveSig]
		public static extern int SteamAPI_GetHSteamPipe();

		[PreserveSig]
		public static extern int SteamAPI_GetHSteamUser();

		[PreserveSig]
		public static extern IntPtr SteamInternal_CreateInterface(InteropHelp.UTF8StringHandle ver);

		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateUserInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		[PreserveSig]
		public static extern IntPtr SteamInternal_FindOrCreateGameServerInterface(HSteamUser hSteamUser, InteropHelp.UTF8StringHandle pszVersion);

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_Init();

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe hSteamPipe, IntPtr pCallbackMsg);

		[PreserveSig]
		public static extern void SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe hSteamPipe);

		[PreserveSig]
		public static extern bool SteamAPI_ManualDispatch_GetAPICallResult(HSteamPipe hSteamPipe, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed);

		[PreserveSig]
		public static extern int SteamGameServer_GetHSteamPipe();

		[PreserveSig]
		public static extern int ISteamApps_GetLaunchCommandLine(IntPtr instancePtr, IntPtr pszCommandLine, int cubCommandLine);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUser(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamFriends(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUtils(IntPtr instancePtr, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmaking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMatchmakingServers(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUserStats(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamApps(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamNetworking(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemoteStorage(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamScreenshots(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamGameSearch(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTTP(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamUGC(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamAppList(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusic(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamMusicRemote(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamHTMLSurface(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInventory(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamVideo(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParentalSettings(IntPtr instancePtr, HSteamUser hSteamuser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamInput(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamParties(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamClient_GetISteamRemotePlay(IntPtr instancePtr, HSteamUser hSteamUser, HSteamPipe hSteamPipe, InteropHelp.UTF8StringHandle pchVersion);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetPersonaName(IntPtr instancePtr);

		[PreserveSig]
		public static extern IntPtr ISteamFriends_GetFriendPersonaName(IntPtr instancePtr, CSteamID steamIDFriend);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayToUser(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchDialog, CSteamID steamID);

		[PreserveSig]
		public static extern void ISteamFriends_ActivateGameOverlayInviteDialog(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_CreateLobby(IntPtr instancePtr, ELobbyType eLobbyType, int cMaxMembers);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_JoinLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern void ISteamMatchmaking_LeaveLobby(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern int ISteamMatchmaking_GetNumLobbyMembers(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyMemberByIndex(IntPtr instancePtr, CSteamID steamIDLobby, int iMember);

		[PreserveSig]
		public static extern bool ISteamMatchmaking_SetLobbyJoinable(IntPtr instancePtr, CSteamID steamIDLobby, bool bLobbyJoinable);

		[PreserveSig]
		public static extern ulong ISteamMatchmaking_GetLobbyOwner(IntPtr instancePtr, CSteamID steamIDLobby);

		[PreserveSig]
		public static extern bool ISteamNetworking_SendP2PPacket(IntPtr instancePtr, CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_IsP2PPacketAvailable(IntPtr instancePtr, out uint pcubMsgSize, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_ReadP2PPacket(IntPtr instancePtr, byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel);

		[PreserveSig]
		public static extern bool ISteamNetworking_AcceptP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[PreserveSig]
		public static extern bool ISteamNetworking_CloseP2PSessionWithUser(IntPtr instancePtr, CSteamID steamIDRemote);

		[PreserveSig]
		public static extern bool ISteamNetworking_GetP2PSessionState(IntPtr instancePtr, CSteamID steamIDRemote, out P2PSessionState_t pConnectionState);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileWrite(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubData);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_FileRead(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile, byte[] pvData, int cubDataToRead);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileDelete(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern bool ISteamRemoteStorage_FileExists(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern int ISteamRemoteStorage_GetFileSize(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchFile);

		[PreserveSig]
		public static extern ulong ISteamUser_GetSteamID(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out int pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_GetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, out float pData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatInt32(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, int nData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetStatFloat(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName, float fData);

		[PreserveSig]
		public static extern bool ISteamUserStats_SetAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamUserStats_ClearAchievement(IntPtr instancePtr, InteropHelp.UTF8StringHandle pchName);

		[PreserveSig]
		public static extern bool ISteamUserStats_StoreStats(IntPtr instancePtr);

		[PreserveSig]
		public static extern uint ISteamUtils_GetAppID(IntPtr instancePtr);

		[PreserveSig]
		public static extern bool ISteamUtils_IsOverlayEnabled(IntPtr instancePtr);
	}
}
