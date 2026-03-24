using System;
using System.Collections.Generic;
using PlayFab.EconomyModels;

namespace PlayFab
{
    public static class PlayFabEconomyAPI
    {
        static PlayFabEconomyAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void AddInventoryItems(AddInventoryItemsRequest request,
            Action<AddInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateDraftItem(CreateDraftItemRequest request,
            Action<CreateDraftItemResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateUploadUrls(CreateUploadUrlsRequest request,
            Action<CreateUploadUrlsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteEntityItemReviews(DeleteEntityItemReviewsRequest request,
            Action<DeleteEntityItemReviewsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteInventoryCollection(DeleteInventoryCollectionRequest request,
            Action<DeleteInventoryCollectionResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteInventoryItems(DeleteInventoryItemsRequest request,
            Action<DeleteInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteItem(DeleteItemRequest request, Action<DeleteItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ExecuteInventoryOperations(ExecuteInventoryOperationsRequest request,
            Action<ExecuteInventoryOperationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetCatalogConfig(GetCatalogConfigRequest request,
            Action<GetCatalogConfigResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetDraftItem(GetDraftItemRequest request, Action<GetDraftItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetDraftItems(GetDraftItemsRequest request, Action<GetDraftItemsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetEntityDraftItems(GetEntityDraftItemsRequest request,
            Action<GetEntityDraftItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetEntityItemReview(GetEntityItemReviewRequest request,
            Action<GetEntityItemReviewResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetInventoryCollectionIds(GetInventoryCollectionIdsRequest request,
            Action<GetInventoryCollectionIdsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetInventoryItems(GetInventoryItemsRequest request,
            Action<GetInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItem(GetItemRequest request, Action<GetItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItemContainers(GetItemContainersRequest request,
            Action<GetItemContainersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItemModerationState(GetItemModerationStateRequest request,
            Action<GetItemModerationStateResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItemPublishStatus(GetItemPublishStatusRequest request,
            Action<GetItemPublishStatusResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItemReviews(GetItemReviewsRequest request, Action<GetItemReviewsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItemReviewSummary(GetItemReviewSummaryRequest request,
            Action<GetItemReviewSummaryResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetItems(GetItemsRequest request, Action<GetItemsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetMicrosoftStoreAccessTokens(GetMicrosoftStoreAccessTokensRequest request,
            Action<GetMicrosoftStoreAccessTokensResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetTransactionHistory(GetTransactionHistoryRequest request,
            Action<GetTransactionHistoryResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PublishDraftItem(PublishDraftItemRequest request,
            Action<PublishDraftItemResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void PurchaseInventoryItems(PurchaseInventoryItemsRequest request,
            Action<PurchaseInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemAppleAppStoreInventoryItems(RedeemAppleAppStoreInventoryItemsRequest request,
            Action<RedeemAppleAppStoreInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemGooglePlayInventoryItems(RedeemGooglePlayInventoryItemsRequest request,
            Action<RedeemGooglePlayInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemMicrosoftStoreInventoryItems(RedeemMicrosoftStoreInventoryItemsRequest request,
            Action<RedeemMicrosoftStoreInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemNintendoEShopInventoryItems(RedeemNintendoEShopInventoryItemsRequest request,
            Action<RedeemNintendoEShopInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemPlayStationStoreInventoryItems(RedeemPlayStationStoreInventoryItemsRequest request,
            Action<RedeemPlayStationStoreInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RedeemSteamInventoryItems(RedeemSteamInventoryItemsRequest request,
            Action<RedeemSteamInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ReportItem(ReportItemRequest request, Action<ReportItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ReportItemReview(ReportItemReviewRequest request,
            Action<ReportItemReviewResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ReviewItem(ReviewItemRequest request, Action<ReviewItemResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SearchItems(SearchItemsRequest request, Action<SearchItemsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetItemModerationState(SetItemModerationStateRequest request,
            Action<SetItemModerationStateResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SubmitItemReviewVote(SubmitItemReviewVoteRequest request,
            Action<SubmitItemReviewVoteResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SubtractInventoryItems(SubtractInventoryItemsRequest request,
            Action<SubtractInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void TakedownItemReviews(TakedownItemReviewsRequest request,
            Action<TakedownItemReviewsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void TransferInventoryItems(TransferInventoryItemsRequest request,
            Action<TransferInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateCatalogConfig(UpdateCatalogConfigRequest request,
            Action<UpdateCatalogConfigResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateDraftItem(UpdateDraftItemRequest request,
            Action<UpdateDraftItemResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateInventoryItems(UpdateInventoryItemsRequest request,
            Action<UpdateInventoryItemsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}