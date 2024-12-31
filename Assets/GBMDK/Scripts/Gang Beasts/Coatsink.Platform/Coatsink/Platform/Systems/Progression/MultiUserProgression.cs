using System;
using System.Collections.Generic;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Progression
{
	public class MultiUserProgression : IProgressionManager
	{
		private Dictionary<LocalID, SingleUserProgression> _users;

		private byte[] _key;

		private Func<LocalID, string, byte[], bool, SingleUserProgression> _creator;

		private string _file;

		private bool _cloudStorage;

		public MultiUserProgression(byte[] key, string file, bool cloud, Func<LocalID, string, byte[], bool, SingleUserProgression> creator = null)
		{
		}

		~MultiUserProgression()
		{
		}

		private SingleUserProgression CreateUserProgression(LocalID user)
		{
			return null;
		}

		private void OnUserJoined(LocalID user)
		{
		}

		private void OnUserLeft(LocalID obj)
		{
		}

		private bool HasUser(LocalID user)
		{
			return false;
		}

		public void SetAchievement(LocalID localID, string achievementCode, bool unlock)
		{
		}

		public bool IsAchievementUnlocked(LocalID localID, string achievementCode)
		{
			return false;
		}
	}
}
