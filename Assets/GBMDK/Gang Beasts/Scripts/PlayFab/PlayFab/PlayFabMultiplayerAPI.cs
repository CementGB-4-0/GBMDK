using System;
using System.Collections.Generic;
using PlayFab.MultiplayerModels;

namespace PlayFab
{
    public static class PlayFabMultiplayerAPI
    {
        static PlayFabMultiplayerAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void CancelAllMatchmakingTicketsForPlayer(CancelAllMatchmakingTicketsForPlayerRequest request,
            Action<CancelAllMatchmakingTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CancelAllServerBackfillTicketsForPlayer(
            CancelAllServerBackfillTicketsForPlayerRequest request,
            Action<CancelAllServerBackfillTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CancelMatchmakingTicket(CancelMatchmakingTicketRequest request,
            Action<CancelMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CancelServerBackfillTicket(CancelServerBackfillTicketRequest request,
            Action<CancelServerBackfillTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateBuildAlias(CreateBuildAliasRequest request,
            Action<BuildAliasDetailsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateBuildWithCustomContainer(CreateBuildWithCustomContainerRequest request,
            Action<CreateBuildWithCustomContainerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateBuildWithManagedContainer(CreateBuildWithManagedContainerRequest request,
            Action<CreateBuildWithManagedContainerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateBuildWithProcessBasedServer(CreateBuildWithProcessBasedServerRequest request,
            Action<CreateBuildWithProcessBasedServerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateLobby(CreateLobbyRequest request, Action<CreateLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateMatchmakingTicket(CreateMatchmakingTicketRequest request,
            Action<CreateMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateRemoteUser(CreateRemoteUserRequest request,
            Action<CreateRemoteUserResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateServerBackfillTicket(CreateServerBackfillTicketRequest request,
            Action<CreateServerBackfillTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateServerMatchmakingTicket(CreateServerMatchmakingTicketRequest request,
            Action<CreateMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateTitleMultiplayerServersQuotaChange(
            CreateTitleMultiplayerServersQuotaChangeRequest request,
            Action<CreateTitleMultiplayerServersQuotaChangeResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteAsset(DeleteAssetRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteBuild(DeleteBuildRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteBuildAlias(DeleteBuildAliasRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteBuildRegion(DeleteBuildRegionRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteCertificate(DeleteCertificateRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteContainerImageRepository(DeleteContainerImageRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteLobby(DeleteLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteRemoteUser(DeleteRemoteUserRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void EnableMultiplayerServersForTitle(EnableMultiplayerServersForTitleRequest request,
            Action<EnableMultiplayerServersForTitleResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void FindFriendLobbies(FindFriendLobbiesRequest request,
            Action<FindFriendLobbiesResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void FindLobbies(FindLobbiesRequest request, Action<FindLobbiesResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetAssetDownloadUrl(GetAssetDownloadUrlRequest request,
            Action<GetAssetDownloadUrlResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetAssetUploadUrl(GetAssetUploadUrlRequest request,
            Action<GetAssetUploadUrlResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetBuild(GetBuildRequest request, Action<GetBuildResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetBuildAlias(GetBuildAliasRequest request, Action<BuildAliasDetailsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetContainerRegistryCredentials(GetContainerRegistryCredentialsRequest request,
            Action<GetContainerRegistryCredentialsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetLobby(GetLobbyRequest request, Action<GetLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMatch(GetMatchRequest request, Action<GetMatchResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMatchmakingQueue(GetMatchmakingQueueRequest request,
            Action<GetMatchmakingQueueResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMatchmakingTicket(GetMatchmakingTicketRequest request,
            Action<GetMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMultiplayerServerDetails(GetMultiplayerServerDetailsRequest request,
            Action<GetMultiplayerServerDetailsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMultiplayerServerLogs(GetMultiplayerServerLogsRequest request,
            Action<GetMultiplayerServerLogsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMultiplayerSessionLogsBySessionId(GetMultiplayerSessionLogsBySessionIdRequest request,
            Action<GetMultiplayerServerLogsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetQueueStatistics(GetQueueStatisticsRequest request,
            Action<GetQueueStatisticsResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetRemoteLoginEndpoint(GetRemoteLoginEndpointRequest request,
            Action<GetRemoteLoginEndpointResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetServerBackfillTicket(GetServerBackfillTicketRequest request,
            Action<GetServerBackfillTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitleEnabledForMultiplayerServersStatus(
            GetTitleEnabledForMultiplayerServersStatusRequest request,
            Action<GetTitleEnabledForMultiplayerServersStatusResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitleMultiplayerServersQuotaChange(GetTitleMultiplayerServersQuotaChangeRequest request,
            Action<GetTitleMultiplayerServersQuotaChangeResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTitleMultiplayerServersQuotas(GetTitleMultiplayerServersQuotasRequest request,
            Action<GetTitleMultiplayerServersQuotasResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void InviteToLobby(InviteToLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void JoinArrangedLobby(JoinArrangedLobbyRequest request, Action<JoinLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void JoinLobby(JoinLobbyRequest request, Action<JoinLobbyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void JoinMatchmakingTicket(JoinMatchmakingTicketRequest request,
            Action<JoinMatchmakingTicketResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void LeaveLobby(LeaveLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListArchivedMultiplayerServers(ListMultiplayerServersRequest request,
            Action<ListMultiplayerServersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListAssetSummaries(ListAssetSummariesRequest request,
            Action<ListAssetSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListBuildAliases(ListBuildAliasesRequest request,
            Action<ListBuildAliasesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListBuildSummariesV2(ListBuildSummariesRequest request,
            Action<ListBuildSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListCertificateSummaries(ListCertificateSummariesRequest request,
            Action<ListCertificateSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListContainerImages(ListContainerImagesRequest request,
            Action<ListContainerImagesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListContainerImageTags(ListContainerImageTagsRequest request,
            Action<ListContainerImageTagsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListMatchmakingQueues(ListMatchmakingQueuesRequest request,
            Action<ListMatchmakingQueuesResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListMatchmakingTicketsForPlayer(ListMatchmakingTicketsForPlayerRequest request,
            Action<ListMatchmakingTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListMultiplayerServers(ListMultiplayerServersRequest request,
            Action<ListMultiplayerServersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListPartyQosServers(ListPartyQosServersRequest request,
            Action<ListPartyQosServersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListQosServersForTitle(ListQosServersForTitleRequest request,
            Action<ListQosServersForTitleResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListServerBackfillTicketsForPlayer(ListServerBackfillTicketsForPlayerRequest request,
            Action<ListServerBackfillTicketsForPlayerResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListTitleMultiplayerServersQuotaChanges(
            ListTitleMultiplayerServersQuotaChangesRequest request,
            Action<ListTitleMultiplayerServersQuotaChangesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListVirtualMachineSummaries(ListVirtualMachineSummariesRequest request,
            Action<ListVirtualMachineSummariesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveMatchmakingQueue(RemoveMatchmakingQueueRequest request,
            Action<RemoveMatchmakingQueueResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveMember(RemoveMemberFromLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RequestMultiplayerServer(RequestMultiplayerServerRequest request,
            Action<RequestMultiplayerServerResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RolloverContainerRegistryCredentials(RolloverContainerRegistryCredentialsRequest request,
            Action<RolloverContainerRegistryCredentialsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetMatchmakingQueue(SetMatchmakingQueueRequest request,
            Action<SetMatchmakingQueueResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ShutdownMultiplayerServer(ShutdownMultiplayerServerRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SubscribeToLobbyResource(SubscribeToLobbyResourceRequest request,
            Action<SubscribeToLobbyResourceResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SubscribeToMatchmakingResource(SubscribeToMatchResourceRequest request,
            Action<SubscribeToMatchResourceResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnsubscribeFromLobbyResource(UnsubscribeFromLobbyResourceRequest request,
            Action<LobbyEmptyResult> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnsubscribeFromMatchmakingResource(UnsubscribeFromMatchResourceRequest request,
            Action<UnsubscribeFromMatchResourceResult> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UntagContainerImage(UntagContainerImageRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateBuildAlias(UpdateBuildAliasRequest request,
            Action<BuildAliasDetailsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateBuildName(UpdateBuildNameRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateBuildRegion(UpdateBuildRegionRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateBuildRegions(UpdateBuildRegionsRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateLobby(UpdateLobbyRequest request, Action<LobbyEmptyResult> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UploadCertificate(UploadCertificateRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}