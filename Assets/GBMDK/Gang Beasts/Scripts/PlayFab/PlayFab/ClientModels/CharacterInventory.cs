using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class CharacterInventory : PlayFabBaseModel
    {
        public string CharacterId;

        public List<ItemInstance> Inventory;
    }
}