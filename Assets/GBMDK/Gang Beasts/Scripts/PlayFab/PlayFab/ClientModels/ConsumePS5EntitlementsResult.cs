using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class ConsumePS5EntitlementsResult : PlayFabResultCommon
    {
        public List<ItemInstance> Items;
    }
}