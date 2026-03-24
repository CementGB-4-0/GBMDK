using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
    [Serializable]
    public class GroupRole : PlayFabBaseModel
    {
        public string RoleId;

        public string RoleName;
    }
}