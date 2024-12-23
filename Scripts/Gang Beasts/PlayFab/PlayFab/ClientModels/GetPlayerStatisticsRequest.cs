using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerStatisticsRequest : PlayFabRequestCommon
	{
		public Dictionary<string, string> CustomTags;

		public List<string> StatisticNames;

		public List<StatisticNameVersion> StatisticNameVersions;
	}
}
