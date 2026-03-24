using System;
using System.Collections.Generic;
using PlayFab.EconomyModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabEconomyInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabEconomyInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabEconomyInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void AddInventoryItems(AddInventoryItemsRequest request,
            Action<AddInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateDraftItem(CreateDraftItemRequest request, Action<CreateDraftItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateUploadUrls(CreateUploadUrlsRequest request, Action<CreateUploadUrlsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteEntityItemReviews(DeleteEntityItemReviewsRequest request,
            Action<DeleteEntityItemReviewsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteInventoryCollection(DeleteInventoryCollectionRequest request,
            Action<DeleteInventoryCollectionResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteInventoryItems(DeleteInventoryItemsRequest request,
            Action<DeleteInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteItem(DeleteItemRequest request, Action<DeleteItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ExecuteInventoryOperations(ExecuteInventoryOperationsRequest request,
            Action<ExecuteInventoryOperationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetCatalogConfig(GetCatalogConfigRequest request, Action<GetCatalogConfigResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetDraftItem(GetDraftItemRequest request, Action<GetDraftItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetDraftItems(GetDraftItemsRequest request, Action<GetDraftItemsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetEntityDraftItems(GetEntityDraftItemsRequest request,
            Action<GetEntityDraftItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetEntityItemReview(GetEntityItemReviewRequest request,
            Action<GetEntityItemReviewResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetInventoryCollectionIds(GetInventoryCollectionIdsRequest request,
            Action<GetInventoryCollectionIdsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetInventoryItems(GetInventoryItemsRequest request,
            Action<GetInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItem(GetItemRequest request, Action<GetItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItemContainers(GetItemContainersRequest request,
            Action<GetItemContainersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItemModerationState(GetItemModerationStateRequest request,
            Action<GetItemModerationStateResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItemPublishStatus(GetItemPublishStatusRequest request,
            Action<GetItemPublishStatusResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItemReviews(GetItemReviewsRequest request, Action<GetItemReviewsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItemReviewSummary(GetItemReviewSummaryRequest request,
            Action<GetItemReviewSummaryResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetItems(GetItemsRequest request, Action<GetItemsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetMicrosoftStoreAccessTokens(GetMicrosoftStoreAccessTokensRequest request,
            Action<GetMicrosoftStoreAccessTokensResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetTransactionHistory(GetTransactionHistoryRequest request,
            Action<GetTransactionHistoryResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PublishDraftItem(PublishDraftItemRequest request, Action<PublishDraftItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void PurchaseInventoryItems(PurchaseInventoryItemsRequest request,
            Action<PurchaseInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemAppleAppStoreInventoryItems(RedeemAppleAppStoreInventoryItemsRequest request,
            Action<RedeemAppleAppStoreInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemGooglePlayInventoryItems(RedeemGooglePlayInventoryItemsRequest request,
            Action<RedeemGooglePlayInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemMicrosoftStoreInventoryItems(RedeemMicrosoftStoreInventoryItemsRequest request,
            Action<RedeemMicrosoftStoreInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemNintendoEShopInventoryItems(RedeemNintendoEShopInventoryItemsRequest request,
            Action<RedeemNintendoEShopInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemPlayStationStoreInventoryItems(RedeemPlayStationStoreInventoryItemsRequest request,
            Action<RedeemPlayStationStoreInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RedeemSteamInventoryItems(RedeemSteamInventoryItemsRequest request,
            Action<RedeemSteamInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ReportItem(ReportItemRequest request, Action<ReportItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ReportItemReview(ReportItemReviewRequest request, Action<ReportItemReviewResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ReviewItem(ReviewItemRequest request, Action<ReviewItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SearchItems(SearchItemsRequest request, Action<SearchItemsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetItemModerationState(SetItemModerationStateRequest request,
            Action<SetItemModerationStateResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SubmitItemReviewVote(SubmitItemReviewVoteRequest request,
            Action<SubmitItemReviewVoteResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SubtractInventoryItems(SubtractInventoryItemsRequest request,
            Action<SubtractInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void TakedownItemReviews(TakedownItemReviewsRequest request,
            Action<TakedownItemReviewsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void TransferInventoryItems(TransferInventoryItemsRequest request,
            Action<TransferInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateCatalogConfig(UpdateCatalogConfigRequest request,
            Action<UpdateCatalogConfigResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateDraftItem(UpdateDraftItemRequest request, Action<UpdateDraftItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateInventoryItems(UpdateInventoryItemsRequest request,
            Action<UpdateInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}