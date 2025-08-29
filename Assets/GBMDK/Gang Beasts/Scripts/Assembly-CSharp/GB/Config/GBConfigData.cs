using GB.UnityServices.Matchmaking;
using UnityEngine;

namespace GB.Config
{
	[CreateAssetMenu(fileName = "GangBeastsConfig", menuName = "Gang Beasts/Data/Generate Config File", order = 999)]
	public class GBConfigData : ScriptableObject
	{
		public string RawGameVersion;

		public MatchmakingUtils.MatchmakingPool MatchmakingPool;

		public double NetworkVersion;

		public int InputVersion;

		public long AppIDSteam;

		public long AppIDSteamServer;

		public long AppIDOculus;

		[SerializeField]
		private string _buildVersion;

		[SerializeField]
		private string _commitVersion;

		[SerializeField]
		private string _lastMainVersion;

		[SerializeField]
		private string _mainDevBranch;

		[SerializeField]
		public string DemoEvent;

		[SerializeField]
		public bool AutoUpdateVersion;

		public string GameVersion => null;

		public string CommitVersion => null;

		public string BuildVersion => null;

		public string CommitVersionShort => null;

		public double UsedNetworkVersion => 0.0;

		public string LastMain => null;

		public string MainDevBranch => null;

		public void SetGitInfo(string buildVersion, string commitNumber)
		{
		}

		public void SetGitLastMain(string master)
		{
		}

		public void SetMainDevBranch(string mainDev)
		{
		}

		public string GetVersion()
		{
			return null;
		}
	}
}
