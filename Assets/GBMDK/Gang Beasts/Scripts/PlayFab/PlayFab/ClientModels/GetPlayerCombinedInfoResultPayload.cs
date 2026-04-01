using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
    [Serializable]
    public class GetPlayerCombinedInfoResultPayload : PlayFabBaseModel
    {
        public UserAccountInfo AccountInfo;

        public List<CharacterInventory> CharacterInventories;

        public List<CharacterResult> CharacterList;

        public PlayerProfileModel PlayerProfile;

        public List<StatisticValue> PlayerStatistics;

        public uint UserDataVersion;

        public List<ItemInstance> UserInventory;

        public uint UserReadOnlyDataVersion;

        public Dictionary<string, string> TitleData;

        public Dictionary<string, UserDataRecord> UserData;

        public Dictionary<string, UserDataRecord> UserReadOnlyData;

        public Dictionary<string, int> UserVirtualCurrency;

        public Dictionary<string, VirtualCurrencyRechargeTime> UserVirtualCurrencyRechargeTimes;
    }
}