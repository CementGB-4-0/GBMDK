using System;
using System.Collections.Generic;
using PlayFab.DataModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabDataInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabDataInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabDataInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void AbortFileUploads(AbortFileUploadsRequest request, Action<AbortFileUploadsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteFiles(DeleteFilesRequest request, Action<DeleteFilesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void FinalizeFileUploads(FinalizeFileUploadsRequest request,
            Action<FinalizeFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetFiles(GetFilesRequest request, Action<GetFilesResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetObjects(GetObjectsRequest request, Action<GetObjectsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void InitiateFileUploads(InitiateFileUploadsRequest request,
            Action<InitiateFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void SetObjects(SetObjectsRequest request, Action<SetObjectsResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}