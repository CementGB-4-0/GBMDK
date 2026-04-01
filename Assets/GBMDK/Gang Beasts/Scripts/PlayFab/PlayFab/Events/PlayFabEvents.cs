using System.Runtime.CompilerServices;
using PlayFab.AuthenticationModels;
using PlayFab.ClientModels;
using PlayFab.CloudScriptModels;
using PlayFab.DataModels;
using PlayFab.EconomyModels;
using PlayFab.EventsModels;
using PlayFab.ExperimentationModels;
using PlayFab.GroupsModels;
using PlayFab.InsightsModels;
using PlayFab.Internal;
using PlayFab.LocalizationModels;
using PlayFab.MultiplayerModels;
using PlayFab.ProfilesModels;
using PlayFab.SharedModels;
using EmptyResponse = PlayFab.AuthenticationModels.EmptyResponse;
using EmptyResult = PlayFab.ClientModels.EmptyResult;
using ExecuteCloudScriptResult = PlayFab.ClientModels.ExecuteCloudScriptResult;

namespace PlayFab.Events
{
    public class PlayFabEvents
    {
        public delegate void PlayFabErrorEvent(PlayFabRequestCommon request, PlayFabError error);

        public delegate void PlayFabRequestEvent<in TRequest>(TRequest request) where TRequest : PlayFabRequestCommon;

        public delegate void PlayFabResultEvent<in TResult>(TResult result) where TResult : PlayFabResultCommon;

        private static PlayFabEvents _instance;

        private PlayFabEvents()
        {
        }

        public event PlayFabRequestEvent<AuthenticateCustomIdRequest>
            OnAuthenticationAuthenticateGameServerWithCustomIdRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<AuthenticateCustomIdResult>
            OnAuthenticationAuthenticateGameServerWithCustomIdResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<DeleteRequest> OnAuthenticationDeleteRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<EmptyResponse> OnAuthenticationDeleteResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetEntityTokenRequest> OnAuthenticationGetEntityTokenRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetEntityTokenResponse> OnAuthenticationGetEntityTokenResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ValidateEntityTokenRequest> OnAuthenticationValidateEntityTokenRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ValidateEntityTokenResponse> OnAuthenticationValidateEntityTokenResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LoginResult> OnLoginResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AcceptTradeRequest> OnAcceptTradeRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AcceptTradeResponse> OnAcceptTradeResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddFriendRequest> OnAddFriendRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AddFriendResult> OnAddFriendResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddGenericIDRequest> OnAddGenericIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AddGenericIDResult> OnAddGenericIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddOrUpdateContactEmailRequest> OnAddOrUpdateContactEmailRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AddOrUpdateContactEmailResult> OnAddOrUpdateContactEmailResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddSharedGroupMembersRequest> OnAddSharedGroupMembersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AddSharedGroupMembersResult> OnAddSharedGroupMembersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddUsernamePasswordRequest> OnAddUsernamePasswordRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AddUsernamePasswordResult> OnAddUsernamePasswordResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddUserVirtualCurrencyRequest> OnAddUserVirtualCurrencyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnAddUserVirtualCurrencyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AndroidDevicePushNotificationRegistrationRequest>
            OnAndroidDevicePushNotificationRegistrationRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<AndroidDevicePushNotificationRegistrationResult>
            OnAndroidDevicePushNotificationRegistrationResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<AttributeInstallRequest> OnAttributeInstallRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AttributeInstallResult> OnAttributeInstallResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CancelTradeRequest> OnCancelTradeRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CancelTradeResponse> OnCancelTradeResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ConfirmPurchaseRequest> OnConfirmPurchaseRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ConfirmPurchaseResult> OnConfirmPurchaseResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ConsumeItemRequest> OnConsumeItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ConsumeItemResult> OnConsumeItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ConsumeMicrosoftStoreEntitlementsRequest>
            OnConsumeMicrosoftStoreEntitlementsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ConsumeMicrosoftStoreEntitlementsResponse>
            OnConsumeMicrosoftStoreEntitlementsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ConsumePS5EntitlementsRequest> OnConsumePS5EntitlementsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ConsumePS5EntitlementsResult> OnConsumePS5EntitlementsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ConsumePSNEntitlementsRequest> OnConsumePSNEntitlementsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ConsumePSNEntitlementsResult> OnConsumePSNEntitlementsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ConsumeXboxEntitlementsRequest> OnConsumeXboxEntitlementsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ConsumeXboxEntitlementsResult> OnConsumeXboxEntitlementsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateSharedGroupRequest> OnCreateSharedGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateSharedGroupResult> OnCreateSharedGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ExecuteCloudScriptRequest> OnExecuteCloudScriptRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExecuteCloudScriptResult> OnExecuteCloudScriptResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetAccountInfoRequest> OnGetAccountInfoRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetAccountInfoResult> OnGetAccountInfoResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetAdPlacementsRequest> OnGetAdPlacementsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetAdPlacementsResult> OnGetAdPlacementsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListUsersCharactersRequest> OnGetAllUsersCharactersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListUsersCharactersResult> OnGetAllUsersCharactersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetCatalogItemsRequest> OnGetCatalogItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCatalogItemsResult> OnGetCatalogItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetCharacterDataRequest> OnGetCharacterDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCharacterDataResult> OnGetCharacterDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetCharacterInventoryRequest> OnGetCharacterInventoryRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCharacterInventoryResult> OnGetCharacterInventoryResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetCharacterLeaderboardRequest> OnGetCharacterLeaderboardRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCharacterLeaderboardResult> OnGetCharacterLeaderboardResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetCharacterDataRequest> OnGetCharacterReadOnlyDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCharacterDataResult> OnGetCharacterReadOnlyDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetCharacterStatisticsRequest> OnGetCharacterStatisticsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCharacterStatisticsResult> OnGetCharacterStatisticsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetContentDownloadUrlRequest> OnGetContentDownloadUrlRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetContentDownloadUrlResult> OnGetContentDownloadUrlResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CurrentGamesRequest> OnGetCurrentGamesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CurrentGamesResult> OnGetCurrentGamesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetFriendLeaderboardRequest> OnGetFriendLeaderboardRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetLeaderboardResult> OnGetFriendLeaderboardResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetFriendLeaderboardAroundPlayerRequest>
            OnGetFriendLeaderboardAroundPlayerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetFriendLeaderboardAroundPlayerResult>
            OnGetFriendLeaderboardAroundPlayerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetFriendsListRequest> OnGetFriendsListRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetFriendsListResult> OnGetFriendsListResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GameServerRegionsRequest> OnGetGameServerRegionsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GameServerRegionsResult> OnGetGameServerRegionsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetLeaderboardRequest> OnGetLeaderboardRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetLeaderboardResult> OnGetLeaderboardResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetLeaderboardAroundCharacterRequest>
            OnGetLeaderboardAroundCharacterRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetLeaderboardAroundCharacterResult> OnGetLeaderboardAroundCharacterResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetLeaderboardAroundPlayerRequest> OnGetLeaderboardAroundPlayerRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetLeaderboardAroundPlayerResult> OnGetLeaderboardAroundPlayerResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetLeaderboardForUsersCharactersRequest>
            OnGetLeaderboardForUserCharactersRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetLeaderboardForUsersCharactersResult>
            OnGetLeaderboardForUserCharactersResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPaymentTokenRequest> OnGetPaymentTokenRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPaymentTokenResult> OnGetPaymentTokenResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPhotonAuthenticationTokenRequest> OnGetPhotonAuthenticationTokenRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPhotonAuthenticationTokenResult> OnGetPhotonAuthenticationTokenResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerCombinedInfoRequest> OnGetPlayerCombinedInfoRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerCombinedInfoResult> OnGetPlayerCombinedInfoResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerProfileRequest> OnGetPlayerProfileRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerProfileResult> OnGetPlayerProfileResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerSegmentsRequest> OnGetPlayerSegmentsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerSegmentsResult> OnGetPlayerSegmentsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerStatisticsRequest> OnGetPlayerStatisticsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerStatisticsResult> OnGetPlayerStatisticsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerStatisticVersionsRequest> OnGetPlayerStatisticVersionsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerStatisticVersionsResult> OnGetPlayerStatisticVersionsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerTagsRequest> OnGetPlayerTagsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerTagsResult> OnGetPlayerTagsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayerTradesRequest> OnGetPlayerTradesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayerTradesResponse> OnGetPlayerTradesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayFabIDsFromFacebookIDsRequest> OnGetPlayFabIDsFromFacebookIDsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayFabIDsFromFacebookIDsResult> OnGetPlayFabIDsFromFacebookIDsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayFabIDsFromFacebookInstantGamesIdsRequest>
            OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromFacebookInstantGamesIdsResult>
            OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromGameCenterIDsRequest>
            OnGetPlayFabIDsFromGameCenterIDsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromGameCenterIDsResult>
            OnGetPlayFabIDsFromGameCenterIDsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromGenericIDsRequest> OnGetPlayFabIDsFromGenericIDsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayFabIDsFromGenericIDsResult> OnGetPlayFabIDsFromGenericIDsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayFabIDsFromGoogleIDsRequest> OnGetPlayFabIDsFromGoogleIDsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayFabIDsFromGoogleIDsResult> OnGetPlayFabIDsFromGoogleIDsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest>
            OnGetPlayFabIDsFromGooglePlayGamesPlayerIDsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>
            OnGetPlayFabIDsFromGooglePlayGamesPlayerIDsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromKongregateIDsRequest>
            OnGetPlayFabIDsFromKongregateIDsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromKongregateIDsResult>
            OnGetPlayFabIDsFromKongregateIDsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromNintendoServiceAccountIdsRequest>
            OnGetPlayFabIDsFromNintendoServiceAccountIdsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromNintendoServiceAccountIdsResult>
            OnGetPlayFabIDsFromNintendoServiceAccountIdsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest>
            OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>
            OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromPSNAccountIDsRequest>
            OnGetPlayFabIDsFromPSNAccountIDsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetPlayFabIDsFromPSNAccountIDsResult>
            OnGetPlayFabIDsFromPSNAccountIDsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetPlayFabIDsFromSteamIDsRequest> OnGetPlayFabIDsFromSteamIDsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayFabIDsFromSteamIDsResult> OnGetPlayFabIDsFromSteamIDsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayFabIDsFromTwitchIDsRequest> OnGetPlayFabIDsFromTwitchIDsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayFabIDsFromTwitchIDsResult> OnGetPlayFabIDsFromTwitchIDsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPlayFabIDsFromXboxLiveIDsRequest> OnGetPlayFabIDsFromXboxLiveIDsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPlayFabIDsFromXboxLiveIDsResult> OnGetPlayFabIDsFromXboxLiveIDsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPublisherDataRequest> OnGetPublisherDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPublisherDataResult> OnGetPublisherDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetPurchaseRequest> OnGetPurchaseRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetPurchaseResult> OnGetPurchaseResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetSharedGroupDataRequest> OnGetSharedGroupDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetSharedGroupDataResult> OnGetSharedGroupDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetStoreItemsRequest> OnGetStoreItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetStoreItemsResult> OnGetStoreItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTimeRequest> OnGetTimeRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetTimeResult> OnGetTimeResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTitleDataRequest> OnGetTitleDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetTitleDataResult> OnGetTitleDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTitleNewsRequest> OnGetTitleNewsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetTitleNewsResult> OnGetTitleNewsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTitlePublicKeyRequest> OnGetTitlePublicKeyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetTitlePublicKeyResult> OnGetTitlePublicKeyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTradeStatusRequest> OnGetTradeStatusRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetTradeStatusResponse> OnGetTradeStatusResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetUserDataResult> OnGetUserDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetUserInventoryRequest> OnGetUserInventoryRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetUserInventoryResult> OnGetUserInventoryResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserPublisherDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetUserDataResult> OnGetUserPublisherDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserPublisherReadOnlyDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetUserDataResult> OnGetUserPublisherReadOnlyDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserReadOnlyDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetUserDataResult> OnGetUserReadOnlyDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GrantCharacterToUserRequest> OnGrantCharacterToUserRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GrantCharacterToUserResult> OnGrantCharacterToUserResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkAndroidDeviceIDRequest> OnLinkAndroidDeviceIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkAndroidDeviceIDResult> OnLinkAndroidDeviceIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkAppleRequest> OnLinkAppleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<EmptyResult> OnLinkAppleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkCustomIDRequest> OnLinkCustomIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkCustomIDResult> OnLinkCustomIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkFacebookAccountRequest> OnLinkFacebookAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkFacebookAccountResult> OnLinkFacebookAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkFacebookInstantGamesIdRequest> OnLinkFacebookInstantGamesIdRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkFacebookInstantGamesIdResult> OnLinkFacebookInstantGamesIdResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkGameCenterAccountRequest> OnLinkGameCenterAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkGameCenterAccountResult> OnLinkGameCenterAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkGoogleAccountRequest> OnLinkGoogleAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkGoogleAccountResult> OnLinkGoogleAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkGooglePlayGamesServicesAccountRequest>
            OnLinkGooglePlayGamesServicesAccountRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<LinkGooglePlayGamesServicesAccountResult>
            OnLinkGooglePlayGamesServicesAccountResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<LinkIOSDeviceIDRequest> OnLinkIOSDeviceIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkIOSDeviceIDResult> OnLinkIOSDeviceIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkKongregateAccountRequest> OnLinkKongregateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkKongregateAccountResult> OnLinkKongregateResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkNintendoServiceAccountRequest> OnLinkNintendoServiceAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<EmptyResult> OnLinkNintendoServiceAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkNintendoSwitchDeviceIdRequest> OnLinkNintendoSwitchDeviceIdRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkNintendoSwitchDeviceIdResult> OnLinkNintendoSwitchDeviceIdResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkOpenIdConnectRequest> OnLinkOpenIdConnectRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<EmptyResult> OnLinkOpenIdConnectResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkPSNAccountRequest> OnLinkPSNAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkPSNAccountResult> OnLinkPSNAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkSteamAccountRequest> OnLinkSteamAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkSteamAccountResult> OnLinkSteamAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkTwitchAccountRequest> OnLinkTwitchRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkTwitchAccountResult> OnLinkTwitchResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LinkXboxAccountRequest> OnLinkXboxAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LinkXboxAccountResult> OnLinkXboxAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithAndroidDeviceIDRequest> OnLoginWithAndroidDeviceIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithAppleRequest> OnLoginWithAppleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithCustomIDRequest> OnLoginWithCustomIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithEmailAddressRequest> OnLoginWithEmailAddressRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithFacebookRequest> OnLoginWithFacebookRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithFacebookInstantGamesIdRequest>
            OnLoginWithFacebookInstantGamesIdRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<LoginWithGameCenterRequest> OnLoginWithGameCenterRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithGoogleAccountRequest> OnLoginWithGoogleAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithGooglePlayGamesServicesRequest>
            OnLoginWithGooglePlayGamesServicesRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<LoginWithIOSDeviceIDRequest> OnLoginWithIOSDeviceIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithKongregateRequest> OnLoginWithKongregateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithNintendoServiceAccountRequest>
            OnLoginWithNintendoServiceAccountRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<LoginWithNintendoSwitchDeviceIdRequest>
            OnLoginWithNintendoSwitchDeviceIdRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<LoginWithOpenIdConnectRequest> OnLoginWithOpenIdConnectRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithPlayFabRequest> OnLoginWithPlayFabRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithPSNRequest> OnLoginWithPSNRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithSteamRequest> OnLoginWithSteamRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithTwitchRequest> OnLoginWithTwitchRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LoginWithXboxRequest> OnLoginWithXboxRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<MatchmakeRequest> OnMatchmakeRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MatchmakeResult> OnMatchmakeResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<OpenTradeRequest> OnOpenTradeRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<OpenTradeResponse> OnOpenTradeResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<PayForPurchaseRequest> OnPayForPurchaseRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<PayForPurchaseResult> OnPayForPurchaseResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<PurchaseItemRequest> OnPurchaseItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<PurchaseItemResult> OnPurchaseItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RedeemCouponRequest> OnRedeemCouponRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RedeemCouponResult> OnRedeemCouponResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RefreshPSNAuthTokenRequest> OnRefreshPSNAuthTokenRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ClientModels.EmptyResponse> OnRefreshPSNAuthTokenResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RegisterForIOSPushNotificationRequest>
            OnRegisterForIOSPushNotificationRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RegisterForIOSPushNotificationResult>
            OnRegisterForIOSPushNotificationResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RegisterPlayFabUserRequest> OnRegisterPlayFabUserRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RegisterPlayFabUserResult> OnRegisterPlayFabUserResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveContactEmailRequest> OnRemoveContactEmailRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RemoveContactEmailResult> OnRemoveContactEmailResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveFriendRequest> OnRemoveFriendRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RemoveFriendResult> OnRemoveFriendResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveGenericIDRequest> OnRemoveGenericIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RemoveGenericIDResult> OnRemoveGenericIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveSharedGroupMembersRequest> OnRemoveSharedGroupMembersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RemoveSharedGroupMembersResult> OnRemoveSharedGroupMembersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ReportAdActivityRequest> OnReportAdActivityRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ReportAdActivityResult> OnReportAdActivityResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeviceInfoRequest> OnReportDeviceInfoRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ClientModels.EmptyResponse> OnReportDeviceInfoResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ReportPlayerClientRequest> OnReportPlayerRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ReportPlayerClientResult> OnReportPlayerResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RestoreIOSPurchasesRequest> OnRestoreIOSPurchasesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RestoreIOSPurchasesResult> OnRestoreIOSPurchasesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RewardAdActivityRequest> OnRewardAdActivityRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RewardAdActivityResult> OnRewardAdActivityResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SendAccountRecoveryEmailRequest> OnSendAccountRecoveryEmailRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SendAccountRecoveryEmailResult> OnSendAccountRecoveryEmailResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SetFriendTagsRequest> OnSetFriendTagsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetFriendTagsResult> OnSetFriendTagsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SetPlayerSecretRequest> OnSetPlayerSecretRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetPlayerSecretResult> OnSetPlayerSecretResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<StartPurchaseRequest> OnStartPurchaseRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<StartPurchaseResult> OnStartPurchaseResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SubtractUserVirtualCurrencyRequest> OnSubtractUserVirtualCurrencyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnSubtractUserVirtualCurrencyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkAndroidDeviceIDRequest> OnUnlinkAndroidDeviceIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkAndroidDeviceIDResult> OnUnlinkAndroidDeviceIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkAppleRequest> OnUnlinkAppleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ClientModels.EmptyResponse> OnUnlinkAppleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkCustomIDRequest> OnUnlinkCustomIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkCustomIDResult> OnUnlinkCustomIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkFacebookAccountRequest> OnUnlinkFacebookAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkFacebookAccountResult> OnUnlinkFacebookAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkFacebookInstantGamesIdRequest> OnUnlinkFacebookInstantGamesIdRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkFacebookInstantGamesIdResult> OnUnlinkFacebookInstantGamesIdResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkGameCenterAccountRequest> OnUnlinkGameCenterAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkGameCenterAccountResult> OnUnlinkGameCenterAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkGoogleAccountRequest> OnUnlinkGoogleAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkGoogleAccountResult> OnUnlinkGoogleAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkGooglePlayGamesServicesAccountRequest>
            OnUnlinkGooglePlayGamesServicesAccountRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<UnlinkGooglePlayGamesServicesAccountResult>
            OnUnlinkGooglePlayGamesServicesAccountResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<UnlinkIOSDeviceIDRequest> OnUnlinkIOSDeviceIDRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkIOSDeviceIDResult> OnUnlinkIOSDeviceIDResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkKongregateAccountRequest> OnUnlinkKongregateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkKongregateAccountResult> OnUnlinkKongregateResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkNintendoServiceAccountRequest> OnUnlinkNintendoServiceAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ClientModels.EmptyResponse> OnUnlinkNintendoServiceAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkNintendoSwitchDeviceIdRequest> OnUnlinkNintendoSwitchDeviceIdRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkNintendoSwitchDeviceIdResult> OnUnlinkNintendoSwitchDeviceIdResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkOpenIdConnectRequest> OnUnlinkOpenIdConnectRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ClientModels.EmptyResponse> OnUnlinkOpenIdConnectResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkPSNAccountRequest> OnUnlinkPSNAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkPSNAccountResult> OnUnlinkPSNAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkSteamAccountRequest> OnUnlinkSteamAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkSteamAccountResult> OnUnlinkSteamAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkTwitchAccountRequest> OnUnlinkTwitchRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkTwitchAccountResult> OnUnlinkTwitchResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlinkXboxAccountRequest> OnUnlinkXboxAccountRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlinkXboxAccountResult> OnUnlinkXboxAccountResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlockContainerInstanceRequest> OnUnlockContainerInstanceRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlockContainerItemResult> OnUnlockContainerInstanceResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnlockContainerItemRequest> OnUnlockContainerItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UnlockContainerItemResult> OnUnlockContainerItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateAvatarUrlRequest> OnUpdateAvatarUrlRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ClientModels.EmptyResponse> OnUpdateAvatarUrlResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnUpdateCharacterDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateCharacterDataResult> OnUpdateCharacterDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateCharacterStatisticsRequest> OnUpdateCharacterStatisticsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateCharacterStatisticsResult> OnUpdateCharacterStatisticsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdatePlayerStatisticsRequest> OnUpdatePlayerStatisticsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdatePlayerStatisticsResult> OnUpdatePlayerStatisticsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateSharedGroupDataRequest> OnUpdateSharedGroupDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateSharedGroupDataResult> OnUpdateSharedGroupDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateUserDataRequest> OnUpdateUserDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateUserDataResult> OnUpdateUserDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateUserDataRequest> OnUpdateUserPublisherDataRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateUserDataResult> OnUpdateUserPublisherDataResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateUserTitleDisplayNameRequest> OnUpdateUserTitleDisplayNameRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateUserTitleDisplayNameResult> OnUpdateUserTitleDisplayNameResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ValidateAmazonReceiptRequest> OnValidateAmazonIAPReceiptRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ValidateAmazonReceiptResult> OnValidateAmazonIAPReceiptResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ValidateGooglePlayPurchaseRequest> OnValidateGooglePlayPurchaseRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ValidateGooglePlayPurchaseResult> OnValidateGooglePlayPurchaseResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ValidateIOSReceiptRequest> OnValidateIOSReceiptRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ValidateIOSReceiptResult> OnValidateIOSReceiptResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ValidateWindowsReceiptRequest> OnValidateWindowsStoreReceiptRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ValidateWindowsReceiptResult> OnValidateWindowsStoreReceiptResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<WriteClientCharacterEventRequest> OnWriteCharacterEventRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<WriteEventResponse> OnWriteCharacterEventResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<WriteClientPlayerEventRequest> OnWritePlayerEventRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<WriteEventResponse> OnWritePlayerEventResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<WriteTitleEventRequest> OnWriteTitleEventRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<WriteEventResponse> OnWriteTitleEventResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ExecuteEntityCloudScriptRequest>
            OnCloudScriptExecuteEntityCloudScriptRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CloudScriptModels.ExecuteCloudScriptResult>
            OnCloudScriptExecuteEntityCloudScriptResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ExecuteFunctionRequest> OnCloudScriptExecuteFunctionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExecuteFunctionResult> OnCloudScriptExecuteFunctionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetFunctionRequest> OnCloudScriptGetFunctionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetFunctionResult> OnCloudScriptGetFunctionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListFunctionsRequest> OnCloudScriptListFunctionsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListFunctionsResult> OnCloudScriptListFunctionsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListFunctionsRequest> OnCloudScriptListHttpFunctionsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListHttpFunctionsResult> OnCloudScriptListHttpFunctionsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListFunctionsRequest> OnCloudScriptListQueuedFunctionsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListQueuedFunctionsResult> OnCloudScriptListQueuedFunctionsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<PostFunctionResultForEntityTriggeredActionRequest>
            OnCloudScriptPostFunctionResultForEntityTriggeredActionRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult>
            OnCloudScriptPostFunctionResultForEntityTriggeredActionResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<PostFunctionResultForFunctionExecutionRequest>
            OnCloudScriptPostFunctionResultForFunctionExecutionRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult>
            OnCloudScriptPostFunctionResultForFunctionExecutionResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<PostFunctionResultForPlayerTriggeredActionRequest>
            OnCloudScriptPostFunctionResultForPlayerTriggeredActionRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult>
            OnCloudScriptPostFunctionResultForPlayerTriggeredActionResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<PostFunctionResultForScheduledTaskRequest>
            OnCloudScriptPostFunctionResultForScheduledTaskRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult>
            OnCloudScriptPostFunctionResultForScheduledTaskResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RegisterHttpFunctionRequest> OnCloudScriptRegisterHttpFunctionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult> OnCloudScriptRegisterHttpFunctionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RegisterQueuedFunctionRequest> OnCloudScriptRegisterQueuedFunctionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult> OnCloudScriptRegisterQueuedFunctionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnregisterFunctionRequest> OnCloudScriptUnregisterFunctionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CloudScriptModels.EmptyResult> OnCloudScriptUnregisterFunctionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AbortFileUploadsRequest> OnDataAbortFileUploadsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AbortFileUploadsResponse> OnDataAbortFileUploadsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteFilesRequest> OnDataDeleteFilesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<DeleteFilesResponse> OnDataDeleteFilesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<FinalizeFileUploadsRequest> OnDataFinalizeFileUploadsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<FinalizeFileUploadsResponse> OnDataFinalizeFileUploadsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetFilesRequest> OnDataGetFilesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetFilesResponse> OnDataGetFilesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetObjectsRequest> OnDataGetObjectsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetObjectsResponse> OnDataGetObjectsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InitiateFileUploadsRequest> OnDataInitiateFileUploadsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InitiateFileUploadsResponse> OnDataInitiateFileUploadsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SetObjectsRequest> OnDataSetObjectsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetObjectsResponse> OnDataSetObjectsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddInventoryItemsRequest> OnEconomyAddInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<AddInventoryItemsResponse> OnEconomyAddInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateDraftItemRequest> OnEconomyCreateDraftItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateDraftItemResponse> OnEconomyCreateDraftItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateUploadUrlsRequest> OnEconomyCreateUploadUrlsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateUploadUrlsResponse> OnEconomyCreateUploadUrlsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteEntityItemReviewsRequest> OnEconomyDeleteEntityItemReviewsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<DeleteEntityItemReviewsResponse> OnEconomyDeleteEntityItemReviewsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteInventoryCollectionRequest>
            OnEconomyDeleteInventoryCollectionRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<DeleteInventoryCollectionResponse> OnEconomyDeleteInventoryCollectionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteInventoryItemsRequest> OnEconomyDeleteInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<DeleteInventoryItemsResponse> OnEconomyDeleteInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteItemRequest> OnEconomyDeleteItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<DeleteItemResponse> OnEconomyDeleteItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ExecuteInventoryOperationsRequest>
            OnEconomyExecuteInventoryOperationsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ExecuteInventoryOperationsResponse>
            OnEconomyExecuteInventoryOperationsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetCatalogConfigRequest> OnEconomyGetCatalogConfigRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetCatalogConfigResponse> OnEconomyGetCatalogConfigResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetDraftItemRequest> OnEconomyGetDraftItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetDraftItemResponse> OnEconomyGetDraftItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetDraftItemsRequest> OnEconomyGetDraftItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetDraftItemsResponse> OnEconomyGetDraftItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetEntityDraftItemsRequest> OnEconomyGetEntityDraftItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetEntityDraftItemsResponse> OnEconomyGetEntityDraftItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetEntityItemReviewRequest> OnEconomyGetEntityItemReviewRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetEntityItemReviewResponse> OnEconomyGetEntityItemReviewResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetInventoryCollectionIdsRequest>
            OnEconomyGetInventoryCollectionIdsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetInventoryCollectionIdsResponse> OnEconomyGetInventoryCollectionIdsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetInventoryItemsRequest> OnEconomyGetInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetInventoryItemsResponse> OnEconomyGetInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemRequest> OnEconomyGetItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemResponse> OnEconomyGetItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemContainersRequest> OnEconomyGetItemContainersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemContainersResponse> OnEconomyGetItemContainersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemModerationStateRequest> OnEconomyGetItemModerationStateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemModerationStateResponse> OnEconomyGetItemModerationStateResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemPublishStatusRequest> OnEconomyGetItemPublishStatusRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemPublishStatusResponse> OnEconomyGetItemPublishStatusResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemReviewsRequest> OnEconomyGetItemReviewsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemReviewsResponse> OnEconomyGetItemReviewsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemReviewSummaryRequest> OnEconomyGetItemReviewSummaryRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemReviewSummaryResponse> OnEconomyGetItemReviewSummaryResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetItemsRequest> OnEconomyGetItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetItemsResponse> OnEconomyGetItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetMicrosoftStoreAccessTokensRequest>
            OnEconomyGetMicrosoftStoreAccessTokensRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetMicrosoftStoreAccessTokensResponse>
            OnEconomyGetMicrosoftStoreAccessTokensResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetTransactionHistoryRequest> OnEconomyGetTransactionHistoryRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetTransactionHistoryResponse> OnEconomyGetTransactionHistoryResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<PublishDraftItemRequest> OnEconomyPublishDraftItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<PublishDraftItemResponse> OnEconomyPublishDraftItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<PurchaseInventoryItemsRequest> OnEconomyPurchaseInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<PurchaseInventoryItemsResponse> OnEconomyPurchaseInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RedeemAppleAppStoreInventoryItemsRequest>
            OnEconomyRedeemAppleAppStoreInventoryItemsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RedeemAppleAppStoreInventoryItemsResponse>
            OnEconomyRedeemAppleAppStoreInventoryItemsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RedeemGooglePlayInventoryItemsRequest>
            OnEconomyRedeemGooglePlayInventoryItemsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RedeemGooglePlayInventoryItemsResponse>
            OnEconomyRedeemGooglePlayInventoryItemsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RedeemMicrosoftStoreInventoryItemsRequest>
            OnEconomyRedeemMicrosoftStoreInventoryItemsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RedeemMicrosoftStoreInventoryItemsResponse>
            OnEconomyRedeemMicrosoftStoreInventoryItemsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RedeemNintendoEShopInventoryItemsRequest>
            OnEconomyRedeemNintendoEShopInventoryItemsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RedeemNintendoEShopInventoryItemsResponse>
            OnEconomyRedeemNintendoEShopInventoryItemsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RedeemPlayStationStoreInventoryItemsRequest>
            OnEconomyRedeemPlayStationStoreInventoryItemsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RedeemPlayStationStoreInventoryItemsResponse>
            OnEconomyRedeemPlayStationStoreInventoryItemsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RedeemSteamInventoryItemsRequest>
            OnEconomyRedeemSteamInventoryItemsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RedeemSteamInventoryItemsResponse> OnEconomyRedeemSteamInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ReportItemRequest> OnEconomyReportItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ReportItemResponse> OnEconomyReportItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ReportItemReviewRequest> OnEconomyReportItemReviewRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ReportItemReviewResponse> OnEconomyReportItemReviewResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ReviewItemRequest> OnEconomyReviewItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ReviewItemResponse> OnEconomyReviewItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SearchItemsRequest> OnEconomySearchItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SearchItemsResponse> OnEconomySearchItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SetItemModerationStateRequest> OnEconomySetItemModerationStateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetItemModerationStateResponse> OnEconomySetItemModerationStateResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SubmitItemReviewVoteRequest> OnEconomySubmitItemReviewVoteRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SubmitItemReviewVoteResponse> OnEconomySubmitItemReviewVoteResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SubtractInventoryItemsRequest> OnEconomySubtractInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SubtractInventoryItemsResponse> OnEconomySubtractInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<TakedownItemReviewsRequest> OnEconomyTakedownItemReviewsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<TakedownItemReviewsResponse> OnEconomyTakedownItemReviewsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<TransferInventoryItemsRequest> OnEconomyTransferInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<TransferInventoryItemsResponse> OnEconomyTransferInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateCatalogConfigRequest> OnEconomyUpdateCatalogConfigRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateCatalogConfigResponse> OnEconomyUpdateCatalogConfigResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateDraftItemRequest> OnEconomyUpdateDraftItemRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateDraftItemResponse> OnEconomyUpdateDraftItemResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateInventoryItemsRequest> OnEconomyUpdateInventoryItemsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateInventoryItemsResponse> OnEconomyUpdateInventoryItemsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<WriteEventsRequest> OnEventsWriteEventsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<WriteEventsResponse> OnEventsWriteEventsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<WriteEventsRequest> OnEventsWriteTelemetryEventsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<WriteEventsResponse> OnEventsWriteTelemetryEventsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateExclusionGroupRequest> OnExperimentationCreateExclusionGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateExclusionGroupResult> OnExperimentationCreateExclusionGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateExperimentRequest> OnExperimentationCreateExperimentRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateExperimentResult> OnExperimentationCreateExperimentResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteExclusionGroupRequest> OnExperimentationDeleteExclusionGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExperimentationModels.EmptyResponse>
            OnExperimentationDeleteExclusionGroupResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<DeleteExperimentRequest> OnExperimentationDeleteExperimentRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExperimentationModels.EmptyResponse>
            OnExperimentationDeleteExperimentResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetExclusionGroupsRequest> OnExperimentationGetExclusionGroupsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetExclusionGroupsResult> OnExperimentationGetExclusionGroupsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetExclusionGroupTrafficRequest>
            OnExperimentationGetExclusionGroupTrafficRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetExclusionGroupTrafficResult>
            OnExperimentationGetExclusionGroupTrafficResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetExperimentsRequest> OnExperimentationGetExperimentsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetExperimentsResult> OnExperimentationGetExperimentsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetLatestScorecardRequest> OnExperimentationGetLatestScorecardRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetLatestScorecardResult> OnExperimentationGetLatestScorecardResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTreatmentAssignmentRequest>
            OnExperimentationGetTreatmentAssignmentRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetTreatmentAssignmentResult> OnExperimentationGetTreatmentAssignmentResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<StartExperimentRequest> OnExperimentationStartExperimentRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExperimentationModels.EmptyResponse> OnExperimentationStartExperimentResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<StopExperimentRequest> OnExperimentationStopExperimentRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExperimentationModels.EmptyResponse> OnExperimentationStopExperimentResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateExclusionGroupRequest> OnExperimentationUpdateExclusionGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExperimentationModels.EmptyResponse>
            OnExperimentationUpdateExclusionGroupResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<UpdateExperimentRequest> OnExperimentationUpdateExperimentRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ExperimentationModels.EmptyResponse>
            OnExperimentationUpdateExperimentResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<AcceptGroupApplicationRequest> OnGroupsAcceptGroupApplicationRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsAcceptGroupApplicationResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AcceptGroupInvitationRequest> OnGroupsAcceptGroupInvitationRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsAcceptGroupInvitationResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<AddMembersRequest> OnGroupsAddMembersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsAddMembersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ApplyToGroupRequest> OnGroupsApplyToGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ApplyToGroupResponse> OnGroupsApplyToGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<BlockEntityRequest> OnGroupsBlockEntityRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsBlockEntityResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ChangeMemberRoleRequest> OnGroupsChangeMemberRoleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsChangeMemberRoleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateGroupRequest> OnGroupsCreateGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateGroupResponse> OnGroupsCreateGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateGroupRoleRequest> OnGroupsCreateRoleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateGroupRoleResponse> OnGroupsCreateRoleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteGroupRequest> OnGroupsDeleteGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsDeleteGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteRoleRequest> OnGroupsDeleteRoleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsDeleteRoleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetGroupRequest> OnGroupsGetGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetGroupResponse> OnGroupsGetGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InviteToGroupRequest> OnGroupsInviteToGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InviteToGroupResponse> OnGroupsInviteToGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<IsMemberRequest> OnGroupsIsMemberRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<IsMemberResponse> OnGroupsIsMemberResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListGroupApplicationsRequest> OnGroupsListGroupApplicationsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListGroupApplicationsResponse> OnGroupsListGroupApplicationsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListGroupBlocksRequest> OnGroupsListGroupBlocksRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListGroupBlocksResponse> OnGroupsListGroupBlocksResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListGroupInvitationsRequest> OnGroupsListGroupInvitationsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListGroupInvitationsResponse> OnGroupsListGroupInvitationsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListGroupMembersRequest> OnGroupsListGroupMembersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListGroupMembersResponse> OnGroupsListGroupMembersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListMembershipRequest> OnGroupsListMembershipRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListMembershipResponse> OnGroupsListMembershipResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListMembershipOpportunitiesRequest>
            OnGroupsListMembershipOpportunitiesRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListMembershipOpportunitiesResponse>
            OnGroupsListMembershipOpportunitiesResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RemoveGroupApplicationRequest> OnGroupsRemoveGroupApplicationRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsRemoveGroupApplicationResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveGroupInvitationRequest> OnGroupsRemoveGroupInvitationRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsRemoveGroupInvitationResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveMembersRequest> OnGroupsRemoveMembersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsRemoveMembersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnblockEntityRequest> OnGroupsUnblockEntityRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GroupsModels.EmptyResponse> OnGroupsUnblockEntityResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateGroupRequest> OnGroupsUpdateGroupRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateGroupResponse> OnGroupsUpdateGroupResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateGroupRoleRequest> OnGroupsUpdateRoleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<UpdateGroupRoleResponse> OnGroupsUpdateRoleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InsightsEmptyRequest> OnInsightsGetDetailsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InsightsGetDetailsResponse> OnInsightsGetDetailsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InsightsEmptyRequest> OnInsightsGetLimitsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InsightsGetLimitsResponse> OnInsightsGetLimitsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InsightsGetOperationStatusRequest> OnInsightsGetOperationStatusRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InsightsGetOperationStatusResponse> OnInsightsGetOperationStatusResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InsightsGetPendingOperationsRequest> OnInsightsGetPendingOperationsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InsightsGetPendingOperationsResponse> OnInsightsGetPendingOperationsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InsightsSetPerformanceRequest> OnInsightsSetPerformanceRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InsightsOperationResponse> OnInsightsSetPerformanceResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<InsightsSetStorageRetentionRequest> OnInsightsSetStorageRetentionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<InsightsOperationResponse> OnInsightsSetStorageRetentionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetLanguageListRequest> OnLocalizationGetLanguageListRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetLanguageListResponse> OnLocalizationGetLanguageListResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CancelAllMatchmakingTicketsForPlayerRequest>
            OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CancelAllMatchmakingTicketsForPlayerResult>
            OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CancelAllServerBackfillTicketsForPlayerRequest>
            OnMultiplayerCancelAllServerBackfillTicketsForPlayerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CancelAllServerBackfillTicketsForPlayerResult>
            OnMultiplayerCancelAllServerBackfillTicketsForPlayerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CancelMatchmakingTicketRequest>
            OnMultiplayerCancelMatchmakingTicketRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CancelMatchmakingTicketResult> OnMultiplayerCancelMatchmakingTicketResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CancelServerBackfillTicketRequest>
            OnMultiplayerCancelServerBackfillTicketRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CancelServerBackfillTicketResult>
            OnMultiplayerCancelServerBackfillTicketResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CreateBuildAliasRequest> OnMultiplayerCreateBuildAliasRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<BuildAliasDetailsResponse> OnMultiplayerCreateBuildAliasResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateBuildWithCustomContainerRequest>
            OnMultiplayerCreateBuildWithCustomContainerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateBuildWithCustomContainerResponse>
            OnMultiplayerCreateBuildWithCustomContainerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CreateBuildWithManagedContainerRequest>
            OnMultiplayerCreateBuildWithManagedContainerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateBuildWithManagedContainerResponse>
            OnMultiplayerCreateBuildWithManagedContainerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CreateBuildWithProcessBasedServerRequest>
            OnMultiplayerCreateBuildWithProcessBasedServerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateBuildWithProcessBasedServerResponse>
            OnMultiplayerCreateBuildWithProcessBasedServerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CreateLobbyRequest> OnMultiplayerCreateLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateLobbyResult> OnMultiplayerCreateLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateMatchmakingTicketRequest>
            OnMultiplayerCreateMatchmakingTicketRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateMatchmakingTicketResult> OnMultiplayerCreateMatchmakingTicketResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateRemoteUserRequest> OnMultiplayerCreateRemoteUserRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<CreateRemoteUserResponse> OnMultiplayerCreateRemoteUserResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<CreateServerBackfillTicketRequest>
            OnMultiplayerCreateServerBackfillTicketRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateServerBackfillTicketResult>
            OnMultiplayerCreateServerBackfillTicketResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CreateServerMatchmakingTicketRequest>
            OnMultiplayerCreateServerMatchmakingTicketRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateMatchmakingTicketResult>
            OnMultiplayerCreateServerMatchmakingTicketResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<CreateTitleMultiplayerServersQuotaChangeRequest>
            OnMultiplayerCreateTitleMultiplayerServersQuotaChangeRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<CreateTitleMultiplayerServersQuotaChangeResponse>
            OnMultiplayerCreateTitleMultiplayerServersQuotaChangeResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<DeleteAssetRequest> OnMultiplayerDeleteAssetRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerDeleteAssetResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteBuildRequest> OnMultiplayerDeleteBuildRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerDeleteBuildResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteBuildAliasRequest> OnMultiplayerDeleteBuildAliasRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerDeleteBuildAliasResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteBuildRegionRequest> OnMultiplayerDeleteBuildRegionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerDeleteBuildRegionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteCertificateRequest> OnMultiplayerDeleteCertificateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerDeleteCertificateResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteContainerImageRequest>
            OnMultiplayerDeleteContainerImageRepositoryRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse>
            OnMultiplayerDeleteContainerImageRepositoryResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<DeleteLobbyRequest> OnMultiplayerDeleteLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LobbyEmptyResult> OnMultiplayerDeleteLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<DeleteRemoteUserRequest> OnMultiplayerDeleteRemoteUserRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerDeleteRemoteUserResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<EnableMultiplayerServersForTitleRequest>
            OnMultiplayerEnableMultiplayerServersForTitleRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<EnableMultiplayerServersForTitleResponse>
            OnMultiplayerEnableMultiplayerServersForTitleResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<FindFriendLobbiesRequest> OnMultiplayerFindFriendLobbiesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<FindFriendLobbiesResult> OnMultiplayerFindFriendLobbiesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<FindLobbiesRequest> OnMultiplayerFindLobbiesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<FindLobbiesResult> OnMultiplayerFindLobbiesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetAssetDownloadUrlRequest> OnMultiplayerGetAssetDownloadUrlRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetAssetDownloadUrlResponse> OnMultiplayerGetAssetDownloadUrlResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetAssetUploadUrlRequest> OnMultiplayerGetAssetUploadUrlRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetAssetUploadUrlResponse> OnMultiplayerGetAssetUploadUrlResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetBuildRequest> OnMultiplayerGetBuildRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetBuildResponse> OnMultiplayerGetBuildResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetBuildAliasRequest> OnMultiplayerGetBuildAliasRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<BuildAliasDetailsResponse> OnMultiplayerGetBuildAliasResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetContainerRegistryCredentialsRequest>
            OnMultiplayerGetContainerRegistryCredentialsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetContainerRegistryCredentialsResponse>
            OnMultiplayerGetContainerRegistryCredentialsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetLobbyRequest> OnMultiplayerGetLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetLobbyResult> OnMultiplayerGetLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetMatchRequest> OnMultiplayerGetMatchRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetMatchResult> OnMultiplayerGetMatchResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetMatchmakingQueueRequest> OnMultiplayerGetMatchmakingQueueRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetMatchmakingQueueResult> OnMultiplayerGetMatchmakingQueueResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetMatchmakingTicketRequest> OnMultiplayerGetMatchmakingTicketRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetMatchmakingTicketResult> OnMultiplayerGetMatchmakingTicketResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetMultiplayerServerDetailsRequest>
            OnMultiplayerGetMultiplayerServerDetailsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetMultiplayerServerDetailsResponse>
            OnMultiplayerGetMultiplayerServerDetailsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetMultiplayerServerLogsRequest>
            OnMultiplayerGetMultiplayerServerLogsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetMultiplayerServerLogsResponse>
            OnMultiplayerGetMultiplayerServerLogsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetMultiplayerSessionLogsBySessionIdRequest>
            OnMultiplayerGetMultiplayerSessionLogsBySessionIdRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetMultiplayerServerLogsResponse>
            OnMultiplayerGetMultiplayerSessionLogsBySessionIdResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetQueueStatisticsRequest> OnMultiplayerGetQueueStatisticsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetQueueStatisticsResult> OnMultiplayerGetQueueStatisticsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetRemoteLoginEndpointRequest> OnMultiplayerGetRemoteLoginEndpointRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetRemoteLoginEndpointResponse> OnMultiplayerGetRemoteLoginEndpointResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetServerBackfillTicketRequest>
            OnMultiplayerGetServerBackfillTicketRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetServerBackfillTicketResult> OnMultiplayerGetServerBackfillTicketResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTitleEnabledForMultiplayerServersStatusRequest>
            OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetTitleEnabledForMultiplayerServersStatusResponse>
            OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetTitleMultiplayerServersQuotaChangeRequest>
            OnMultiplayerGetTitleMultiplayerServersQuotaChangeRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetTitleMultiplayerServersQuotaChangeResponse>
            OnMultiplayerGetTitleMultiplayerServersQuotaChangeResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetTitleMultiplayerServersQuotasRequest>
            OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetTitleMultiplayerServersQuotasResponse>
            OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<InviteToLobbyRequest> OnMultiplayerInviteToLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LobbyEmptyResult> OnMultiplayerInviteToLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<JoinArrangedLobbyRequest> OnMultiplayerJoinArrangedLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<JoinLobbyResult> OnMultiplayerJoinArrangedLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<JoinLobbyRequest> OnMultiplayerJoinLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<JoinLobbyResult> OnMultiplayerJoinLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<JoinMatchmakingTicketRequest> OnMultiplayerJoinMatchmakingTicketRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<JoinMatchmakingTicketResult> OnMultiplayerJoinMatchmakingTicketResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<LeaveLobbyRequest> OnMultiplayerLeaveLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LobbyEmptyResult> OnMultiplayerLeaveLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListMultiplayerServersRequest>
            OnMultiplayerListArchivedMultiplayerServersRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListMultiplayerServersResponse>
            OnMultiplayerListArchivedMultiplayerServersResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ListAssetSummariesRequest> OnMultiplayerListAssetSummariesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListAssetSummariesResponse> OnMultiplayerListAssetSummariesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListBuildAliasesRequest> OnMultiplayerListBuildAliasesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListBuildAliasesResponse> OnMultiplayerListBuildAliasesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListBuildSummariesRequest> OnMultiplayerListBuildSummariesV2RequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListBuildSummariesResponse> OnMultiplayerListBuildSummariesV2ResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListCertificateSummariesRequest>
            OnMultiplayerListCertificateSummariesRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListCertificateSummariesResponse>
            OnMultiplayerListCertificateSummariesResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ListContainerImagesRequest> OnMultiplayerListContainerImagesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListContainerImagesResponse> OnMultiplayerListContainerImagesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListContainerImageTagsRequest> OnMultiplayerListContainerImageTagsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListContainerImageTagsResponse> OnMultiplayerListContainerImageTagsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListMatchmakingQueuesRequest> OnMultiplayerListMatchmakingQueuesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListMatchmakingQueuesResult> OnMultiplayerListMatchmakingQueuesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListMatchmakingTicketsForPlayerRequest>
            OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListMatchmakingTicketsForPlayerResult>
            OnMultiplayerListMatchmakingTicketsForPlayerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ListMultiplayerServersRequest> OnMultiplayerListMultiplayerServersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListMultiplayerServersResponse> OnMultiplayerListMultiplayerServersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListPartyQosServersRequest> OnMultiplayerListPartyQosServersRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListPartyQosServersResponse> OnMultiplayerListPartyQosServersResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListQosServersForTitleRequest> OnMultiplayerListQosServersForTitleRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<ListQosServersForTitleResponse> OnMultiplayerListQosServersForTitleResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ListServerBackfillTicketsForPlayerRequest>
            OnMultiplayerListServerBackfillTicketsForPlayerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListServerBackfillTicketsForPlayerResult>
            OnMultiplayerListServerBackfillTicketsForPlayerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ListTitleMultiplayerServersQuotaChangesRequest>
            OnMultiplayerListTitleMultiplayerServersQuotaChangesRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListTitleMultiplayerServersQuotaChangesResponse>
            OnMultiplayerListTitleMultiplayerServersQuotaChangesResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<ListVirtualMachineSummariesRequest>
            OnMultiplayerListVirtualMachineSummariesRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<ListVirtualMachineSummariesResponse>
            OnMultiplayerListVirtualMachineSummariesResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RemoveMatchmakingQueueRequest> OnMultiplayerRemoveMatchmakingQueueRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<RemoveMatchmakingQueueResult> OnMultiplayerRemoveMatchmakingQueueResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RemoveMemberFromLobbyRequest> OnMultiplayerRemoveMemberRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LobbyEmptyResult> OnMultiplayerRemoveMemberResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<RequestMultiplayerServerRequest>
            OnMultiplayerRequestMultiplayerServerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RequestMultiplayerServerResponse>
            OnMultiplayerRequestMultiplayerServerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<RolloverContainerRegistryCredentialsRequest>
            OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<RolloverContainerRegistryCredentialsResponse>
            OnMultiplayerRolloverContainerRegistryCredentialsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<SetMatchmakingQueueRequest> OnMultiplayerSetMatchmakingQueueRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetMatchmakingQueueResult> OnMultiplayerSetMatchmakingQueueResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<ShutdownMultiplayerServerRequest>
            OnMultiplayerShutdownMultiplayerServerRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse>
            OnMultiplayerShutdownMultiplayerServerResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<SubscribeToLobbyResourceRequest>
            OnMultiplayerSubscribeToLobbyResourceRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<SubscribeToLobbyResourceResult> OnMultiplayerSubscribeToLobbyResourceResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SubscribeToMatchResourceRequest>
            OnMultiplayerSubscribeToMatchmakingResourceRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<SubscribeToMatchResourceResult>
            OnMultiplayerSubscribeToMatchmakingResourceResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<UnsubscribeFromLobbyResourceRequest>
            OnMultiplayerUnsubscribeFromLobbyResourceRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<LobbyEmptyResult> OnMultiplayerUnsubscribeFromLobbyResourceResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UnsubscribeFromMatchResourceRequest>
            OnMultiplayerUnsubscribeFromMatchmakingResourceRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<UnsubscribeFromMatchResourceResult>
            OnMultiplayerUnsubscribeFromMatchmakingResourceResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<UntagContainerImageRequest> OnMultiplayerUntagContainerImageRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerUntagContainerImageResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateBuildAliasRequest> OnMultiplayerUpdateBuildAliasRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<BuildAliasDetailsResponse> OnMultiplayerUpdateBuildAliasResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateBuildNameRequest> OnMultiplayerUpdateBuildNameRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerUpdateBuildNameResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateBuildRegionRequest> OnMultiplayerUpdateBuildRegionRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerUpdateBuildRegionResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateBuildRegionsRequest> OnMultiplayerUpdateBuildRegionsRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerUpdateBuildRegionsResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UpdateLobbyRequest> OnMultiplayerUpdateLobbyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<LobbyEmptyResult> OnMultiplayerUpdateLobbyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<UploadCertificateRequest> OnMultiplayerUploadCertificateRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<MultiplayerModels.EmptyResponse> OnMultiplayerUploadCertificateResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetGlobalPolicyRequest> OnProfilesGetGlobalPolicyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetGlobalPolicyResponse> OnProfilesGetGlobalPolicyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetEntityProfileRequest> OnProfilesGetProfileRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetEntityProfileResponse> OnProfilesGetProfileResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetEntityProfilesRequest> OnProfilesGetProfilesRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<GetEntityProfilesResponse> OnProfilesGetProfilesResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<GetTitlePlayersFromMasterPlayerAccountIdsRequest>
            OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetTitlePlayersFromMasterPlayerAccountIdsResponse>
            OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<GetTitlePlayersFromXboxLiveIDsRequest>
            OnProfilesGetTitlePlayersFromXboxLiveIDsRequestEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabResultEvent<GetTitlePlayersFromProviderIDsResponse>
            OnProfilesGetTitlePlayersFromXboxLiveIDsResultEvent
            {
                [CompilerGenerated] add { }
                [CompilerGenerated] remove { }
            }

        public event PlayFabRequestEvent<SetGlobalPolicyRequest> OnProfilesSetGlobalPolicyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetGlobalPolicyResponse> OnProfilesSetGlobalPolicyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SetProfileLanguageRequest> OnProfilesSetProfileLanguageRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetProfileLanguageResponse> OnProfilesSetProfileLanguageResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabRequestEvent<SetEntityProfilePolicyRequest> OnProfilesSetProfilePolicyRequestEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabResultEvent<SetEntityProfilePolicyResponse> OnProfilesSetProfilePolicyResultEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public event PlayFabErrorEvent OnGlobalErrorEvent
        {
            [CompilerGenerated] add { }
            [CompilerGenerated] remove { }
        }

        public static PlayFabEvents Init()
        {
            return null;
        }

        public void UnregisterInstance(object instance)
        {
        }

        private void OnProcessingErrorEvent(PlayFabRequestCommon request, PlayFabError error)
        {
        }

        private void OnProcessingEvent(ApiProcessingEventArgs e)
        {
        }
    }
}