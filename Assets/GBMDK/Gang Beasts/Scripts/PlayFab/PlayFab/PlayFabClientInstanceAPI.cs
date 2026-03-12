using System;
using System.Collections.Generic;
using PlayFab.ClientModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabClientInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabClientInstanceAPI()
        {
        }

        public PlayFabClientInstanceAPI(PlayFabApiSettings settings)
        {
        }

        public PlayFabClientInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabClientInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsClientLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void AcceptTrade(AcceptTradeRequest request, Action<AcceptTradeResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddFriend(AddFriendRequest request, Action<AddFriendResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddGenericID(AddGenericIDRequest request, Action<AddGenericIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddOrUpdateContactEmail(AddOrUpdateContactEmailRequest request,
            Action<AddOrUpdateContactEmailResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddSharedGroupMembers(AddSharedGroupMembersRequest request,
            Action<AddSharedGroupMembersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddUsernamePassword(AddUsernamePasswordRequest request,
            Action<AddUsernamePasswordResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddUserVirtualCurrency(AddUserVirtualCurrencyRequest request,
            Action<ModifyUserVirtualCurrencyResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AndroidDevicePushNotificationRegistration(AndroidDevicePushNotificationRegistrationRequest request,
            Action<AndroidDevicePushNotificationRegistrationResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AttributeInstall(AttributeInstallRequest request, Action<AttributeInstallResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CancelTrade(CancelTradeRequest request, Action<CancelTradeResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ConfirmPurchase(ConfirmPurchaseRequest request, Action<ConfirmPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ConsumeItem(ConsumeItemRequest request, Action<ConsumeItemResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ConsumeMicrosoftStoreEntitlements(ConsumeMicrosoftStoreEntitlementsRequest request,
            Action<ConsumeMicrosoftStoreEntitlementsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ConsumePS5Entitlements(ConsumePS5EntitlementsRequest request,
            Action<ConsumePS5EntitlementsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ConsumePSNEntitlements(ConsumePSNEntitlementsRequest request,
            Action<ConsumePSNEntitlementsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ConsumeXboxEntitlements(ConsumeXboxEntitlementsRequest request,
            Action<ConsumeXboxEntitlementsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateSharedGroup(CreateSharedGroupRequest request, Action<CreateSharedGroupResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ExecuteCloudScript(ExecuteCloudScriptRequest request,
            Action<ExecuteCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ExecuteCloudScript<TOut>(ExecuteCloudScriptRequest request,
            Action<ExecuteCloudScriptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetAccountInfo(GetAccountInfoRequest request, Action<GetAccountInfoResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetAdPlacements(GetAdPlacementsRequest request, Action<GetAdPlacementsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetAllUsersCharacters(ListUsersCharactersRequest request,
            Action<ListUsersCharactersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCatalogItems(GetCatalogItemsRequest request, Action<GetCatalogItemsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCharacterData(GetCharacterDataRequest request, Action<GetCharacterDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCharacterInventory(GetCharacterInventoryRequest request,
            Action<GetCharacterInventoryResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCharacterLeaderboard(GetCharacterLeaderboardRequest request,
            Action<GetCharacterLeaderboardResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCharacterReadOnlyData(GetCharacterDataRequest request,
            Action<GetCharacterDataResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCharacterStatistics(GetCharacterStatisticsRequest request,
            Action<GetCharacterStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetContentDownloadUrl(GetContentDownloadUrlRequest request,
            Action<GetContentDownloadUrlResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        [Obsolete("Use 'MultiplayerServer/ListMultiplayerServers' instead", true)]
        public void GetCurrentGames(CurrentGamesRequest request, Action<CurrentGamesResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetFriendLeaderboard(GetFriendLeaderboardRequest request,
            Action<GetLeaderboardResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetFriendLeaderboardAroundPlayer(GetFriendLeaderboardAroundPlayerRequest request,
            Action<GetFriendLeaderboardAroundPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetFriendsList(GetFriendsListRequest request, Action<GetFriendsListResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        [Obsolete("Use 'MultiplayerServer/ListMultiplayerServers' instead", true)]
        public void GetGameServerRegions(GameServerRegionsRequest request,
            Action<GameServerRegionsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLeaderboard(GetLeaderboardRequest request, Action<GetLeaderboardResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLeaderboardAroundCharacter(GetLeaderboardAroundCharacterRequest request,
            Action<GetLeaderboardAroundCharacterResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLeaderboardAroundPlayer(GetLeaderboardAroundPlayerRequest request,
            Action<GetLeaderboardAroundPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLeaderboardForUserCharacters(GetLeaderboardForUsersCharactersRequest request,
            Action<GetLeaderboardForUsersCharactersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPaymentToken(GetPaymentTokenRequest request, Action<GetPaymentTokenResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPhotonAuthenticationToken(GetPhotonAuthenticationTokenRequest request,
            Action<GetPhotonAuthenticationTokenResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerCombinedInfo(GetPlayerCombinedInfoRequest request,
            Action<GetPlayerCombinedInfoResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerProfile(GetPlayerProfileRequest request, Action<GetPlayerProfileResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerSegments(GetPlayerSegmentsRequest request, Action<GetPlayerSegmentsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerStatistics(GetPlayerStatisticsRequest request,
            Action<GetPlayerStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerStatisticVersions(GetPlayerStatisticVersionsRequest request,
            Action<GetPlayerStatisticVersionsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerTags(GetPlayerTagsRequest request, Action<GetPlayerTagsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayerTrades(GetPlayerTradesRequest request, Action<GetPlayerTradesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromFacebookIDs(GetPlayFabIDsFromFacebookIDsRequest request,
            Action<GetPlayFabIDsFromFacebookIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromFacebookInstantGamesIds(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request,
            Action<GetPlayFabIDsFromFacebookInstantGamesIdsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromGameCenterIDs(GetPlayFabIDsFromGameCenterIDsRequest request,
            Action<GetPlayFabIDsFromGameCenterIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromGenericIDs(GetPlayFabIDsFromGenericIDsRequest request,
            Action<GetPlayFabIDsFromGenericIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromGoogleIDs(GetPlayFabIDsFromGoogleIDsRequest request,
            Action<GetPlayFabIDsFromGoogleIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromGooglePlayGamesPlayerIDs(GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest request,
            Action<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromKongregateIDs(GetPlayFabIDsFromKongregateIDsRequest request,
            Action<GetPlayFabIDsFromKongregateIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromNintendoServiceAccountIds(
            GetPlayFabIDsFromNintendoServiceAccountIdsRequest request,
            Action<GetPlayFabIDsFromNintendoServiceAccountIdsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromNintendoSwitchDeviceIds(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request,
            Action<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromPSNAccountIDs(GetPlayFabIDsFromPSNAccountIDsRequest request,
            Action<GetPlayFabIDsFromPSNAccountIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromSteamIDs(GetPlayFabIDsFromSteamIDsRequest request,
            Action<GetPlayFabIDsFromSteamIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromTwitchIDs(GetPlayFabIDsFromTwitchIDsRequest request,
            Action<GetPlayFabIDsFromTwitchIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPlayFabIDsFromXboxLiveIDs(GetPlayFabIDsFromXboxLiveIDsRequest request,
            Action<GetPlayFabIDsFromXboxLiveIDsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPublisherData(GetPublisherDataRequest request, Action<GetPublisherDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetPurchase(GetPurchaseRequest request, Action<GetPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetSharedGroupData(GetSharedGroupDataRequest request,
            Action<GetSharedGroupDataResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetStoreItems(GetStoreItemsRequest request, Action<GetStoreItemsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTime(GetTimeRequest request, Action<GetTimeResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitleData(GetTitleDataRequest request, Action<GetTitleDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitleNews(GetTitleNewsRequest request, Action<GetTitleNewsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitlePublicKey(GetTitlePublicKeyRequest request, Action<GetTitlePublicKeyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTradeStatus(GetTradeStatusRequest request, Action<GetTradeStatusResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetUserData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetUserInventory(GetUserInventoryRequest request, Action<GetUserInventoryResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetUserPublisherData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetUserPublisherReadOnlyData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetUserReadOnlyData(GetUserDataRequest request, Action<GetUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GrantCharacterToUser(GrantCharacterToUserRequest request,
            Action<GrantCharacterToUserResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkAndroidDeviceID(LinkAndroidDeviceIDRequest request,
            Action<LinkAndroidDeviceIDResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkApple(LinkAppleRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkCustomID(LinkCustomIDRequest request, Action<LinkCustomIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkFacebookAccount(LinkFacebookAccountRequest request,
            Action<LinkFacebookAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkFacebookInstantGamesId(LinkFacebookInstantGamesIdRequest request,
            Action<LinkFacebookInstantGamesIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkGameCenterAccount(LinkGameCenterAccountRequest request,
            Action<LinkGameCenterAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkGoogleAccount(LinkGoogleAccountRequest request, Action<LinkGoogleAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkGooglePlayGamesServicesAccount(LinkGooglePlayGamesServicesAccountRequest request,
            Action<LinkGooglePlayGamesServicesAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkIOSDeviceID(LinkIOSDeviceIDRequest request, Action<LinkIOSDeviceIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkKongregate(LinkKongregateAccountRequest request,
            Action<LinkKongregateAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkNintendoServiceAccount(LinkNintendoServiceAccountRequest request,
            Action<EmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkNintendoSwitchDeviceId(LinkNintendoSwitchDeviceIdRequest request,
            Action<LinkNintendoSwitchDeviceIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkOpenIdConnect(LinkOpenIdConnectRequest request, Action<EmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkPSNAccount(LinkPSNAccountRequest request, Action<LinkPSNAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkSteamAccount(LinkSteamAccountRequest request, Action<LinkSteamAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkTwitch(LinkTwitchAccountRequest request, Action<LinkTwitchAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LinkXboxAccount(LinkXboxAccountRequest request, Action<LinkXboxAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithAndroidDeviceID(LoginWithAndroidDeviceIDRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithApple(LoginWithAppleRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithCustomID(LoginWithCustomIDRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithEmailAddress(LoginWithEmailAddressRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithFacebook(LoginWithFacebookRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithFacebookInstantGamesId(LoginWithFacebookInstantGamesIdRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithGameCenter(LoginWithGameCenterRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithGoogleAccount(LoginWithGoogleAccountRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithGooglePlayGamesServices(LoginWithGooglePlayGamesServicesRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithIOSDeviceID(LoginWithIOSDeviceIDRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithKongregate(LoginWithKongregateRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithNintendoServiceAccount(LoginWithNintendoServiceAccountRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithNintendoSwitchDeviceId(LoginWithNintendoSwitchDeviceIdRequest request,
            Action<LoginResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithOpenIdConnect(LoginWithOpenIdConnectRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithPlayFab(LoginWithPlayFabRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithPSN(LoginWithPSNRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithSteam(LoginWithSteamRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithTwitch(LoginWithTwitchRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LoginWithXbox(LoginWithXboxRequest request, Action<LoginResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        [Obsolete("Use 'Match/CreateMatchmakingTicket' instead", true)]
        public void Matchmake(MatchmakeRequest request, Action<MatchmakeResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void OpenTrade(OpenTradeRequest request, Action<OpenTradeResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PayForPurchase(PayForPurchaseRequest request, Action<PayForPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PurchaseItem(PurchaseItemRequest request, Action<PurchaseItemResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemCoupon(RedeemCouponRequest request, Action<RedeemCouponResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RefreshPSNAuthToken(RefreshPSNAuthTokenRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RegisterForIOSPushNotification(RegisterForIOSPushNotificationRequest request,
            Action<RegisterForIOSPushNotificationResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RegisterPlayFabUser(RegisterPlayFabUserRequest request,
            Action<RegisterPlayFabUserResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveContactEmail(RemoveContactEmailRequest request,
            Action<RemoveContactEmailResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveFriend(RemoveFriendRequest request, Action<RemoveFriendResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveGenericID(RemoveGenericIDRequest request, Action<RemoveGenericIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveSharedGroupMembers(RemoveSharedGroupMembersRequest request,
            Action<RemoveSharedGroupMembersResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ReportAdActivity(ReportAdActivityRequest request, Action<ReportAdActivityResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ReportDeviceInfo(DeviceInfoRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ReportPlayer(ReportPlayerClientRequest request, Action<ReportPlayerClientResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RestoreIOSPurchases(RestoreIOSPurchasesRequest request,
            Action<RestoreIOSPurchasesResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RewardAdActivity(RewardAdActivityRequest request, Action<RewardAdActivityResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SendAccountRecoveryEmail(SendAccountRecoveryEmailRequest request,
            Action<SendAccountRecoveryEmailResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetFriendTags(SetFriendTagsRequest request, Action<SetFriendTagsResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetPlayerSecret(SetPlayerSecretRequest request, Action<SetPlayerSecretResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void StartPurchase(StartPurchaseRequest request, Action<StartPurchaseResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SubtractUserVirtualCurrency(SubtractUserVirtualCurrencyRequest request,
            Action<ModifyUserVirtualCurrencyResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkAndroidDeviceID(UnlinkAndroidDeviceIDRequest request,
            Action<UnlinkAndroidDeviceIDResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkApple(UnlinkAppleRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkCustomID(UnlinkCustomIDRequest request, Action<UnlinkCustomIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkFacebookAccount(UnlinkFacebookAccountRequest request,
            Action<UnlinkFacebookAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkFacebookInstantGamesId(UnlinkFacebookInstantGamesIdRequest request,
            Action<UnlinkFacebookInstantGamesIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkGameCenterAccount(UnlinkGameCenterAccountRequest request,
            Action<UnlinkGameCenterAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkGoogleAccount(UnlinkGoogleAccountRequest request,
            Action<UnlinkGoogleAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkGooglePlayGamesServicesAccount(UnlinkGooglePlayGamesServicesAccountRequest request,
            Action<UnlinkGooglePlayGamesServicesAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkIOSDeviceID(UnlinkIOSDeviceIDRequest request, Action<UnlinkIOSDeviceIDResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkKongregate(UnlinkKongregateAccountRequest request,
            Action<UnlinkKongregateAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkNintendoServiceAccount(UnlinkNintendoServiceAccountRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkNintendoSwitchDeviceId(UnlinkNintendoSwitchDeviceIdRequest request,
            Action<UnlinkNintendoSwitchDeviceIdResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkOpenIdConnect(UnlinkOpenIdConnectRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkPSNAccount(UnlinkPSNAccountRequest request, Action<UnlinkPSNAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkSteamAccount(UnlinkSteamAccountRequest request,
            Action<UnlinkSteamAccountResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkTwitch(UnlinkTwitchAccountRequest request, Action<UnlinkTwitchAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlinkXboxAccount(UnlinkXboxAccountRequest request, Action<UnlinkXboxAccountResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlockContainerInstance(UnlockContainerInstanceRequest request,
            Action<UnlockContainerItemResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnlockContainerItem(UnlockContainerItemRequest request,
            Action<UnlockContainerItemResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateAvatarUrl(UpdateAvatarUrlRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateCharacterData(UpdateCharacterDataRequest request,
            Action<UpdateCharacterDataResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateCharacterStatistics(UpdateCharacterStatisticsRequest request,
            Action<UpdateCharacterStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdatePlayerStatistics(UpdatePlayerStatisticsRequest request,
            Action<UpdatePlayerStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateSharedGroupData(UpdateSharedGroupDataRequest request,
            Action<UpdateSharedGroupDataResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateUserData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateUserPublisherData(UpdateUserDataRequest request, Action<UpdateUserDataResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateUserTitleDisplayName(UpdateUserTitleDisplayNameRequest request,
            Action<UpdateUserTitleDisplayNameResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ValidateAmazonIAPReceipt(ValidateAmazonReceiptRequest request,
            Action<ValidateAmazonReceiptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ValidateGooglePlayPurchase(ValidateGooglePlayPurchaseRequest request,
            Action<ValidateGooglePlayPurchaseResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ValidateIOSReceipt(ValidateIOSReceiptRequest request,
            Action<ValidateIOSReceiptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ValidateWindowsStoreReceipt(ValidateWindowsReceiptRequest request,
            Action<ValidateWindowsReceiptResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void WriteCharacterEvent(WriteClientCharacterEventRequest request,
            Action<WriteEventResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void WritePlayerEvent(WriteClientPlayerEventRequest request, Action<WriteEventResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void WriteTitleEvent(WriteTitleEventRequest request, Action<WriteEventResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}