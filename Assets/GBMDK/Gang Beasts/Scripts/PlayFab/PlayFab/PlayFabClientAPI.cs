using System;
using System.Collections.Generic;
using PlayFab.ClientModels;

namespace PlayFab
{
    public static class PlayFabClientAPI
    {
        static PlayFabClientAPI()
        {
        }

        public static bool IsClientLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void AcceptTrade(AcceptTradeRequest request, Action<AcceptTradeResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddFriend(AddFriendRequest request, Action<AddFriendResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddGenericID(AddGenericIDRequest request, Action<AddGenericIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddOrUpdateContactEmail(AddOrUpdateContactEmailRequest request,
            Action<AddOrUpdateContactEmailResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddSharedGroupMembers(AddSharedGroupMembersRequest request,
            Action<AddSharedGroupMembersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddUsernamePassword(AddUsernamePasswordRequest request,
            Action<AddUsernamePasswordResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddUserVirtualCurrency(AddUserVirtualCurrencyRequest request,
            Action<ModifyUserVirtualCurrencyResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AndroidDevicePushNotificationRegistration(
            AndroidDevicePushNotificationRegistrationRequest request,
            Action<AndroidDevicePushNotificationRegistrationResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AttributeInstall(AttributeInstallRequest request,
            Action<AttributeInstallResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CancelTrade(CancelTradeRequest request, Action<CancelTradeResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ConfirmPurchase(ConfirmPurchaseRequest request, Action<ConfirmPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ConsumeItem(ConsumeItemRequest request, Action<ConsumeItemResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ConsumeMicrosoftStoreEntitlements(ConsumeMicrosoftStoreEntitlementsRequest request,
            Action<ConsumeMicrosoftStoreEntitlementsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ConsumePS5Entitlements(ConsumePS5EntitlementsRequest request,
            Action<ConsumePS5EntitlementsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ConsumePSNEntitlements(ConsumePSNEntitlementsRequest request,
            Action<ConsumePSNEntitlementsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ConsumeXboxEntitlements(ConsumeXboxEntitlementsRequest request,
            Action<ConsumeXboxEntitlementsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateSharedGroup(CreateSharedGroupRequest request,
            Action<CreateSharedGroupResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ExecuteCloudScript(ExecuteCloudScriptRequest request,
            Action<ExecuteCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ExecuteCloudScript<TOut>(ExecuteCloudScriptRequest request,
            Action<ExecuteCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetAccountInfo(GetAccountInfoRequest request, Action<GetAccountInfoResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetAdPlacements(GetAdPlacementsRequest request, Action<GetAdPlacementsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetAllUsersCharacters(ListUsersCharactersRequest request,
            Action<ListUsersCharactersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCatalogItems(GetCatalogItemsRequest request, Action<GetCatalogItemsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCharacterData(GetCharacterDataRequest request,
            Action<GetCharacterDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCharacterInventory(GetCharacterInventoryRequest request,
            Action<GetCharacterInventoryResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCharacterLeaderboard(GetCharacterLeaderboardRequest request,
            Action<GetCharacterLeaderboardResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCharacterReadOnlyData(GetCharacterDataRequest request,
            Action<GetCharacterDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCharacterStatistics(GetCharacterStatisticsRequest request,
            Action<GetCharacterStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetContentDownloadUrl(GetContentDownloadUrlRequest request,
            Action<GetContentDownloadUrlResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        [Obsolete("Use 'MultiplayerServer/ListMultiplayerServers' instead", true)]
        public static void GetCurrentGames(CurrentGamesRequest request, Action<CurrentGamesResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetFriendLeaderboard(GetFriendLeaderboardRequest request,
            Action<GetLeaderboardResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetFriendLeaderboardAroundPlayer(GetFriendLeaderboardAroundPlayerRequest request,
            Action<GetFriendLeaderboardAroundPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetFriendsList(GetFriendsListRequest request, Action<GetFriendsListResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        [Obsolete("Use 'MultiplayerServer/ListMultiplayerServers' instead", true)]
        public static void GetGameServerRegions(GameServerRegionsRequest request,
            Action<GameServerRegionsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLeaderboard(GetLeaderboardRequest request, Action<GetLeaderboardResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLeaderboardAroundCharacter(GetLeaderboardAroundCharacterRequest request,
            Action<GetLeaderboardAroundCharacterResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLeaderboardAroundPlayer(GetLeaderboardAroundPlayerRequest request,
            Action<GetLeaderboardAroundPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLeaderboardForUserCharacters(GetLeaderboardForUsersCharactersRequest request,
            Action<GetLeaderboardForUsersCharactersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPaymentToken(GetPaymentTokenRequest request, Action<GetPaymentTokenResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPhotonAuthenticationToken(GetPhotonAuthenticationTokenRequest request,
            Action<GetPhotonAuthenticationTokenResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerCombinedInfo(GetPlayerCombinedInfoRequest request,
            Action<GetPlayerCombinedInfoResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerProfile(GetPlayerProfileRequest request,
            Action<GetPlayerProfileResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerSegments(GetPlayerSegmentsRequest request,
            Action<GetPlayerSegmentsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerStatistics(GetPlayerStatisticsRequest request,
            Action<GetPlayerStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerStatisticVersions(GetPlayerStatisticVersionsRequest request,
            Action<GetPlayerStatisticVersionsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerTags(GetPlayerTagsRequest request, Action<GetPlayerTagsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayerTrades(GetPlayerTradesRequest request,
            Action<GetPlayerTradesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromFacebookIDs(GetPlayFabIDsFromFacebookIDsRequest request,
            Action<GetPlayFabIDsFromFacebookIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromFacebookInstantGamesIds(
            GetPlayFabIDsFromFacebookInstantGamesIdsRequest request,
            Action<GetPlayFabIDsFromFacebookInstantGamesIdsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromGameCenterIDs(GetPlayFabIDsFromGameCenterIDsRequest request,
            Action<GetPlayFabIDsFromGameCenterIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromGenericIDs(GetPlayFabIDsFromGenericIDsRequest request,
            Action<GetPlayFabIDsFromGenericIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromGoogleIDs(GetPlayFabIDsFromGoogleIDsRequest request,
            Action<GetPlayFabIDsFromGoogleIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromGooglePlayGamesPlayerIDs(
            GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest request,
            Action<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromKongregateIDs(GetPlayFabIDsFromKongregateIDsRequest request,
            Action<GetPlayFabIDsFromKongregateIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromNintendoServiceAccountIds(
            GetPlayFabIDsFromNintendoServiceAccountIdsRequest request,
            Action<GetPlayFabIDsFromNintendoServiceAccountIdsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromNintendoSwitchDeviceIds(
            GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request,
            Action<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromPSNAccountIDs(GetPlayFabIDsFromPSNAccountIDsRequest request,
            Action<GetPlayFabIDsFromPSNAccountIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromSteamIDs(GetPlayFabIDsFromSteamIDsRequest request,
            Action<GetPlayFabIDsFromSteamIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromTwitchIDs(GetPlayFabIDsFromTwitchIDsRequest request,
            Action<GetPlayFabIDsFromTwitchIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPlayFabIDsFromXboxLiveIDs(GetPlayFabIDsFromXboxLiveIDsRequest request,
            Action<GetPlayFabIDsFromXboxLiveIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPublisherData(GetPublisherDataRequest request,
            Action<GetPublisherDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetPurchase(GetPurchaseRequest request, Action<GetPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetSharedGroupData(GetSharedGroupDataRequest request,
            Action<GetSharedGroupDataResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetStoreItems(GetStoreItemsRequest request, Action<GetStoreItemsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTime(GetTimeRequest request, Action<GetTimeResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitleData(GetTitleDataRequest request, Action<GetTitleDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitleNews(GetTitleNewsRequest request, Action<GetTitleNewsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitlePublicKey(GetTitlePublicKeyRequest request,
            Action<GetTitlePublicKeyResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTradeStatus(GetTradeStatusRequest request, Action<GetTradeStatusResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetUserData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetUserInventory(GetUserInventoryRequest request,
            Action<GetUserInventoryResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetUserPublisherData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetUserPublisherReadOnlyData(GetUserDataRequest request,
            Action<GetUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetUserReadOnlyData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GrantCharacterToUser(GrantCharacterToUserRequest request,
            Action<GrantCharacterToUserResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkAndroidDeviceID(LinkAndroidDeviceIDRequest request,
            Action<LinkAndroidDeviceIDResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkApple(LinkAppleRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkCustomID(LinkCustomIDRequest request, Action<LinkCustomIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkFacebookAccount(LinkFacebookAccountRequest request,
            Action<LinkFacebookAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkFacebookInstantGamesId(LinkFacebookInstantGamesIdRequest request,
            Action<LinkFacebookInstantGamesIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkGameCenterAccount(LinkGameCenterAccountRequest request,
            Action<LinkGameCenterAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkGoogleAccount(LinkGoogleAccountRequest request,
            Action<LinkGoogleAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkGooglePlayGamesServicesAccount(LinkGooglePlayGamesServicesAccountRequest request,
            Action<LinkGooglePlayGamesServicesAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkIOSDeviceID(LinkIOSDeviceIDRequest request, Action<LinkIOSDeviceIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkKongregate(LinkKongregateAccountRequest request,
            Action<LinkKongregateAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkNintendoServiceAccount(LinkNintendoServiceAccountRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkNintendoSwitchDeviceId(LinkNintendoSwitchDeviceIdRequest request,
            Action<LinkNintendoSwitchDeviceIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkOpenIdConnect(LinkOpenIdConnectRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkPSNAccount(LinkPSNAccountRequest request, Action<LinkPSNAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkSteamAccount(LinkSteamAccountRequest request,
            Action<LinkSteamAccountResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkTwitch(LinkTwitchAccountRequest request, Action<LinkTwitchAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LinkXboxAccount(LinkXboxAccountRequest request, Action<LinkXboxAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithAndroidDeviceID(LoginWithAndroidDeviceIDRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithApple(LoginWithAppleRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithCustomID(LoginWithCustomIDRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithEmailAddress(LoginWithEmailAddressRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithFacebook(LoginWithFacebookRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithFacebookInstantGamesId(LoginWithFacebookInstantGamesIdRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithGameCenter(LoginWithGameCenterRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithGoogleAccount(LoginWithGoogleAccountRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithGooglePlayGamesServices(LoginWithGooglePlayGamesServicesRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithIOSDeviceID(LoginWithIOSDeviceIDRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithKongregate(LoginWithKongregateRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithNintendoServiceAccount(LoginWithNintendoServiceAccountRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithNintendoSwitchDeviceId(LoginWithNintendoSwitchDeviceIdRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithOpenIdConnect(LoginWithOpenIdConnectRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithPlayFab(LoginWithPlayFabRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithPSN(LoginWithPSNRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithSteam(LoginWithSteamRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithTwitch(LoginWithTwitchRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LoginWithXbox(LoginWithXboxRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        [Obsolete("Use 'Match/CreateMatchmakingTicket' instead", true)]
        public static void Matchmake(MatchmakeRequest request, Action<MatchmakeResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void OpenTrade(OpenTradeRequest request, Action<OpenTradeResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PayForPurchase(PayForPurchaseRequest request, Action<PayForPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PurchaseItem(PurchaseItemRequest request, Action<PurchaseItemResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemCoupon(RedeemCouponRequest request, Action<RedeemCouponResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RefreshPSNAuthToken(RefreshPSNAuthTokenRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RegisterForIOSPushNotification(RegisterForIOSPushNotificationRequest request,
            Action<RegisterForIOSPushNotificationResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RegisterPlayFabUser(RegisterPlayFabUserRequest request,
            Action<RegisterPlayFabUserResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveContactEmail(RemoveContactEmailRequest request,
            Action<RemoveContactEmailResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveFriend(RemoveFriendRequest request, Action<RemoveFriendResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveGenericID(RemoveGenericIDRequest request, Action<RemoveGenericIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveSharedGroupMembers(RemoveSharedGroupMembersRequest request,
            Action<RemoveSharedGroupMembersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ReportAdActivity(ReportAdActivityRequest request,
            Action<ReportAdActivityResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ReportDeviceInfo(DeviceInfoRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ReportPlayer(ReportPlayerClientRequest request,
            Action<ReportPlayerClientResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RestoreIOSPurchases(RestoreIOSPurchasesRequest request,
            Action<RestoreIOSPurchasesResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RewardAdActivity(RewardAdActivityRequest request,
            Action<RewardAdActivityResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SendAccountRecoveryEmail(SendAccountRecoveryEmailRequest request,
            Action<SendAccountRecoveryEmailResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetFriendTags(SetFriendTagsRequest request, Action<SetFriendTagsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetPlayerSecret(SetPlayerSecretRequest request, Action<SetPlayerSecretResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void StartPurchase(StartPurchaseRequest request, Action<StartPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest request,
            Action<ModifyUserVirtualCurrencyResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkAndroidDeviceID(UnlinkAndroidDeviceIDRequest request,
            Action<UnlinkAndroidDeviceIDResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkApple(UnlinkAppleRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkCustomID(UnlinkCustomIDRequest request, Action<UnlinkCustomIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkFacebookAccount(UnlinkFacebookAccountRequest request,
            Action<UnlinkFacebookAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkFacebookInstantGamesId(UnlinkFacebookInstantGamesIdRequest request,
            Action<UnlinkFacebookInstantGamesIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkGameCenterAccount(UnlinkGameCenterAccountRequest request,
            Action<UnlinkGameCenterAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkGoogleAccount(UnlinkGoogleAccountRequest request,
            Action<UnlinkGoogleAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkGooglePlayGamesServicesAccount(UnlinkGooglePlayGamesServicesAccountRequest request,
            Action<UnlinkGooglePlayGamesServicesAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkIOSDeviceID(UnlinkIOSDeviceIDRequest request,
            Action<UnlinkIOSDeviceIDResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkKongregate(UnlinkKongregateAccountRequest request,
            Action<UnlinkKongregateAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkNintendoServiceAccount(UnlinkNintendoServiceAccountRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkNintendoSwitchDeviceId(UnlinkNintendoSwitchDeviceIdRequest request,
            Action<UnlinkNintendoSwitchDeviceIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkOpenIdConnect(UnlinkOpenIdConnectRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkPSNAccount(UnlinkPSNAccountRequest request,
            Action<UnlinkPSNAccountResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkSteamAccount(UnlinkSteamAccountRequest request,
            Action<UnlinkSteamAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkTwitch(UnlinkTwitchAccountRequest request,
            Action<UnlinkTwitchAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlinkXboxAccount(UnlinkXboxAccountRequest request,
            Action<UnlinkXboxAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlockContainerInstance(UnlockContainerInstanceRequest request,
            Action<UnlockContainerItemResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnlockContainerItem(UnlockContainerItemRequest request,
            Action<UnlockContainerItemResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateAvatarUrl(UpdateAvatarUrlRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateCharacterData(UpdateCharacterDataRequest request,
            Action<UpdateCharacterDataResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateCharacterStatistics(UpdateCharacterStatisticsRequest request,
            Action<UpdateCharacterStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdatePlayerStatistics(UpdatePlayerStatisticsRequest request,
            Action<UpdatePlayerStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateSharedGroupData(UpdateSharedGroupDataRequest request,
            Action<UpdateSharedGroupDataResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateUserData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateUserPublisherData(UpdateUserDataRequest request,
            Action<UpdateUserDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateUserTitleDisplayName(UpdateUserTitleDisplayNameRequest request,
            Action<UpdateUserTitleDisplayNameResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ValidateAmazonIAPReceipt(ValidateAmazonReceiptRequest request,
            Action<ValidateAmazonReceiptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ValidateGooglePlayPurchase(ValidateGooglePlayPurchaseRequest request,
            Action<ValidateGooglePlayPurchaseResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ValidateIOSReceipt(ValidateIOSReceiptRequest request,
            Action<ValidateIOSReceiptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ValidateWindowsStoreReceipt(ValidateWindowsReceiptRequest request,
            Action<ValidateWindowsReceiptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void WriteCharacterEvent(WriteClientCharacterEventRequest request,
            Action<WriteEventResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void WritePlayerEvent(WriteClientPlayerEventRequest request,
            Action<WriteEventResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void WriteTitleEvent(WriteTitleEventRequest request, Action<WriteEventResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}