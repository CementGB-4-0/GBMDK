using System;
using System.Collections.Generic;
using PlayFab.DataModels;

namespace PlayFab
{
    public static class PlayFabDataAPI
    {
        static PlayFabDataAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void AbortFileUploads(AbortFileUploadsRequest request,
            Action<AbortFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteFiles(DeleteFilesRequest request, Action<DeleteFilesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void FinalizeFileUploads(FinalizeFileUploadsRequest request,
            Action<FinalizeFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetFiles(GetFilesRequest request, Action<GetFilesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetObjects(GetObjectsRequest request, Action<GetObjectsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void InitiateFileUploads(InitiateFileUploadsRequest request,
            Action<InitiateFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void SetObjects(SetObjectsRequest request, Action<SetObjectsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}