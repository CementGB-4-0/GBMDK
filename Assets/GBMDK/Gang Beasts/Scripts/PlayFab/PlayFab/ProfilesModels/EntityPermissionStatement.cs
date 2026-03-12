using System;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
    [Serializable]
    public class EntityPermissionStatement : PlayFabBaseModel
    {
        public string Action;

        public string Comment;

        public EffectType Effect;

        public string Resource;

        public object Condition;

        public object Principal;
    }
}