using System;
using System.Collections.Generic;
using PlayFab.GroupsModels;

namespace PlayFab
{
    public static class PlayFabGroupsAPI
    {
        static PlayFabGroupsAPI()
        {
        }

        public static bool IsEntityLoggedIn()
        {
            return false;
        }

        public static void ForgetAllCredentials()
        {
        }

        public static void AcceptGroupApplication(AcceptGroupApplicationRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AcceptGroupInvitation(AcceptGroupInvitationRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void AddMembers(AddMembersRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ApplyToGroup(ApplyToGroupRequest request, Action<ApplyToGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void BlockEntity(BlockEntityRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ChangeMemberRole(ChangeMemberRoleRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateGroup(CreateGroupRequest request, Action<CreateGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void CreateRole(CreateGroupRoleRequest request, Action<CreateGroupRoleResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteGroup(DeleteGroupRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void DeleteRole(DeleteRoleRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void GetGroup(GetGroupRequest request, Action<GetGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void InviteToGroup(InviteToGroupRequest request, Action<InviteToGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void IsMember(IsMemberRequest request, Action<IsMemberResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListGroupApplications(ListGroupApplicationsRequest request,
            Action<ListGroupApplicationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListGroupBlocks(ListGroupBlocksRequest request,
            Action<ListGroupBlocksResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListGroupInvitations(ListGroupInvitationsRequest request,
            Action<ListGroupInvitationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListGroupMembers(ListGroupMembersRequest request,
            Action<ListGroupMembersResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListMembership(ListMembershipRequest request, Action<ListMembershipResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void ListMembershipOpportunities(ListMembershipOpportunitiesRequest request,
            Action<ListMembershipOpportunitiesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveGroupApplication(RemoveGroupApplicationRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveGroupInvitation(RemoveGroupInvitationRequest request,
            Action<EmptyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void RemoveMembers(RemoveMembersRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UnblockEntity(UnblockEntityRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateGroup(UpdateGroupRequest request, Action<UpdateGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public static void UpdateRole(UpdateGroupRoleRequest request, Action<UpdateGroupRoleResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}