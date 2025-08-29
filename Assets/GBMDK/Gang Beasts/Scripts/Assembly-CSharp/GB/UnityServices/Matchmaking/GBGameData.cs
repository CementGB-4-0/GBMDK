using System;

namespace GB.UnityServices.Matchmaking
{
	[Serializable]
	public class GBGameData
	{
		public MatchmakingPlatformBucket MatchmakingPlatformBucket;

		public double Version;

		public bool PrivateGame;

		public string MapName;

		public string Gamemode;

		public int NumberOfWins;

		public int StageTimeLimit;

		public uint TotalPlayerCountInclLocal;

		public uint TotalPlayerCountExclLocal;

		public string SessionPassword;
	}
}
