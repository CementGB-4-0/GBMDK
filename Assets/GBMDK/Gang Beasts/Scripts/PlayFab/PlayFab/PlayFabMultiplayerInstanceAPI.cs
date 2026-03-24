using System;
using System.Collections.Generic;
using PlayFab.MultiplayerModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabMultiplayerInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabMultiplayerInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabMultiplayerInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void CancelAllMatchmakingTicketsForPlayer(CancelAllMatchmakingTicketsForPlayerRequest request,
            Action<CancelAllMatchmakingTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CancelAllServerBackfillTicketsForPlayer(CancelAllServerBackfillTicketsForPlayerRequest request,
            Action<CancelAllServerBackfillTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CancelMatchmakingTicket(CancelMatchmakingTicketRequest request,
            Action<CancelMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CancelServerBackfillTicket(CancelServerBackfillTicketRequest request,
            Action<CancelServerBackfillTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateBuildAlias(CreateBuildAliasRequest request, Action<BuildAliasDetailsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateBuildWithCustomContainer(CreateBuildWithCustomContainerRequest request,
            Action<CreateBuildWithCustomContainerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateBuildWithManagedContainer(CreateBuildWithManagedContainerRequest request,
            Action<CreateBuildWithManagedContainerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateBuildWithProcessBasedServer(CreateBuildWithProcessBasedServerRequest request,
            Action<CreateBuildWithProcessBasedServerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateLobby(CreateLobbyRequest request, Action<CreateLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateMatchmakingTicket(CreateMatchmakingTicketRequest request,
            Action<CreateMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateRemoteUser(CreateRemoteUserRequest request, Action<CreateRemoteUserResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateServerBackfillTicket(CreateServerBackfillTicketRequest request,
            Action<CreateServerBackfillTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateServerMatchmakingTicket(CreateServerMatchmakingTicketRequest request,
            Action<CreateMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateTitleMultiplayerServersQuotaChange(CreateTitleMultiplayerServersQuotaChangeRequest request,
            Action<CreateTitleMultiplayerServersQuotaChangeResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteAsset(DeleteAssetRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteBuild(DeleteBuildRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteBuildAlias(DeleteBuildAliasRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteBuildRegion(DeleteBuildRegionRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteCertificate(DeleteCertificateRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteContainerImageRepository(DeleteContainerImageRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteLobby(DeleteLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteRemoteUser(DeleteRemoteUserRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void EnableMultiplayerServersForTitle(EnableMultiplayerServersForTitleRequest request,
            Action<EnableMultiplayerServersForTitleResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void FindFriendLobbies(FindFriendLobbiesRequest request, Action<FindFriendLobbiesResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void FindLobbies(FindLobbiesRequest request, Action<FindLobbiesResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetAssetDownloadUrl(GetAssetDownloadUrlRequest request,
            Action<GetAssetDownloadUrlResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetAssetUploadUrl(GetAssetUploadUrlRequest request,
            Action<GetAssetUploadUrlResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetBuild(GetBuildRequest request, Action<GetBuildResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetBuildAlias(GetBuildAliasRequest request, Action<BuildAliasDetailsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetContainerRegistryCredentials(GetContainerRegistryCredentialsRequest request,
            Action<GetContainerRegistryCredentialsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetLobby(GetLobbyRequest request, Action<GetLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMatch(GetMatchRequest request, Action<GetMatchResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMatchmakingQueue(GetMatchmakingQueueRequest request,
            Action<GetMatchmakingQueueResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMatchmakingTicket(GetMatchmakingTicketRequest request,
            Action<GetMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMultiplayerServerDetails(GetMultiplayerServerDetailsRequest request,
            Action<GetMultiplayerServerDetailsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMultiplayerServerLogs(GetMultiplayerServerLogsRequest request,
            Action<GetMultiplayerServerLogsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMultiplayerSessionLogsBySessionId(GetMultiplayerSessionLogsBySessionIdRequest request,
            Action<GetMultiplayerServerLogsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetQueueStatistics(GetQueueStatisticsRequest request,
            Action<GetQueueStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetRemoteLoginEndpoint(GetRemoteLoginEndpointRequest request,
            Action<GetRemoteLoginEndpointResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetServerBackfillTicket(GetServerBackfillTicketRequest request,
            Action<GetServerBackfillTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitleEnabledForMultiplayerServersStatus(
            GetTitleEnabledForMultiplayerServersStatusRequest request,
            Action<GetTitleEnabledForMultiplayerServersStatusResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitleMultiplayerServersQuotaChange(GetTitleMultiplayerServersQuotaChangeRequest request,
            Action<GetTitleMultiplayerServersQuotaChangeResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTitleMultiplayerServersQuotas(GetTitleMultiplayerServersQuotasRequest request,
            Action<GetTitleMultiplayerServersQuotasResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void InviteToLobby(InviteToLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void JoinArrangedLobby(JoinArrangedLobbyRequest request, Action<JoinLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void JoinLobby(JoinLobbyRequest request, Action<JoinLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void JoinMatchmakingTicket(JoinMatchmakingTicketRequest request,
            Action<JoinMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void LeaveLobby(LeaveLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListArchivedMultiplayerServers(ListMultiplayerServersRequest request,
            Action<ListMultiplayerServersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListAssetSummaries(ListAssetSummariesRequest request,
            Action<ListAssetSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListBuildAliases(ListBuildAliasesRequest request, Action<ListBuildAliasesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListBuildSummariesV2(ListBuildSummariesRequest request,
            Action<ListBuildSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListCertificateSummaries(ListCertificateSummariesRequest request,
            Action<ListCertificateSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListContainerImages(ListContainerImagesRequest request,
            Action<ListContainerImagesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListContainerImageTags(ListContainerImageTagsRequest request,
            Action<ListContainerImageTagsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListMatchmakingQueues(ListMatchmakingQueuesRequest request,
            Action<ListMatchmakingQueuesResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListMatchmakingTicketsForPlayer(ListMatchmakingTicketsForPlayerRequest request,
            Action<ListMatchmakingTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListMultiplayerServers(ListMultiplayerServersRequest request,
            Action<ListMultiplayerServersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListPartyQosServers(ListPartyQosServersRequest request,
            Action<ListPartyQosServersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListQosServersForTitle(ListQosServersForTitleRequest request,
            Action<ListQosServersForTitleResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListServerBackfillTicketsForPlayer(ListServerBackfillTicketsForPlayerRequest request,
            Action<ListServerBackfillTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListTitleMultiplayerServersQuotaChanges(ListTitleMultiplayerServersQuotaChangesRequest request,
            Action<ListTitleMultiplayerServersQuotaChangesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListVirtualMachineSummaries(ListVirtualMachineSummariesRequest request,
            Action<ListVirtualMachineSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveMatchmakingQueue(RemoveMatchmakingQueueRequest request,
            Action<RemoveMatchmakingQueueResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveMember(RemoveMemberFromLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RequestMultiplayerServer(RequestMultiplayerServerRequest request,
            Action<RequestMultiplayerServerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RolloverContainerRegistryCredentials(RolloverContainerRegistryCredentialsRequest request,
            Action<RolloverContainerRegistryCredentialsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetMatchmakingQueue(SetMatchmakingQueueRequest request,
            Action<SetMatchmakingQueueResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ShutdownMultiplayerServer(ShutdownMultiplayerServerRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SubscribeToLobbyResource(SubscribeToLobbyResourceRequest request,
            Action<SubscribeToLobbyResourceResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SubscribeToMatchmakingResource(SubscribeToMatchResourceRequest request,
            Action<SubscribeToMatchResourceResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnsubscribeFromLobbyResource(UnsubscribeFromLobbyResourceRequest request,
            Action<LobbyEmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnsubscribeFromMatchmakingResource(UnsubscribeFromMatchResourceRequest request,
            Action<UnsubscribeFromMatchResourceResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UntagContainerImage(UntagContainerImageRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateBuildAlias(UpdateBuildAliasRequest request, Action<BuildAliasDetailsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateBuildName(UpdateBuildNameRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateBuildRegion(UpdateBuildRegionRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateBuildRegions(UpdateBuildRegionsRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateLobby(UpdateLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UploadCertificate(UploadCertificateRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}