using System;
using System.Collections.Generic;
using PlayFab.GroupsModels;
using PlayFab.SharedModels;

namespace PlayFab
{
    public class PlayFabGroupsInstanceAPI : IPlayFabInstanceApi
    {
        public readonly PlayFabApiSettings apiSettings;

        public readonly PlayFabAuthenticationContext authenticationContext;

        public PlayFabGroupsInstanceAPI(PlayFabAuthenticationContext context)
        {
        }

        public PlayFabGroupsInstanceAPI(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
        {
        }

        public bool IsEntityLoggedIn()
        {
            return false;
        }

        public void ForgetAllCredentials()
        {
        }

        public void AcceptGroupApplication(AcceptGroupApplicationRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AcceptGroupInvitation(AcceptGroupInvitationRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void AddMembers(AddMembersRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ApplyToGroup(ApplyToGroupRequest request, Action<ApplyToGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void BlockEntity(BlockEntityRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ChangeMemberRole(ChangeMemberRoleRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateGroup(CreateGroupRequest request, Action<CreateGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void CreateRole(CreateGroupRoleRequest request, Action<CreateGroupRoleResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteGroup(DeleteGroupRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void DeleteRole(DeleteRoleRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void GetGroup(GetGroupRequest request, Action<GetGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void InviteToGroup(InviteToGroupRequest request, Action<InviteToGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void IsMember(IsMemberRequest request, Action<IsMemberResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListGroupApplications(ListGroupApplicationsRequest request,
            Action<ListGroupApplicationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListGroupBlocks(ListGroupBlocksRequest request, Action<ListGroupBlocksResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListGroupInvitations(ListGroupInvitationsRequest request,
            Action<ListGroupInvitationsResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListGroupMembers(ListGroupMembersRequest request, Action<ListGroupMembersResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListMembership(ListMembershipRequest request, Action<ListMembershipResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void ListMembershipOpportunities(ListMembershipOpportunitiesRequest request,
            Action<ListMembershipOpportunitiesResponse> resultCallback, Action<PlayFabError> errorCallback,
            object customData = null, Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveGroupApplication(RemoveGroupApplicationRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveGroupInvitation(RemoveGroupInvitationRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void RemoveMembers(RemoveMembersRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UnblockEntity(UnblockEntityRequest request, Action<EmptyResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateGroup(UpdateGroupRequest request, Action<UpdateGroupResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }

        public void UpdateRole(UpdateGroupRoleRequest request, Action<UpdateGroupRoleResponse> resultCallback,
            Action<PlayFabError> errorCallback, object customData = null,
            Dictionary<string, string> extraHeaders = null)
        {
        }
    }
}