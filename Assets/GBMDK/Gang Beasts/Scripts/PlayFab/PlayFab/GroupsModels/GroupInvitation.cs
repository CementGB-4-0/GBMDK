using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class GroupInvitation : PlayFabBaseModel
    {
        public EntityKey Group;

        public EntityWithLineage InvitedByEntity;

        public EntityWithLineage InvitedEntity;

        public string RoleId;
        public DateTime Expires;
    }
}