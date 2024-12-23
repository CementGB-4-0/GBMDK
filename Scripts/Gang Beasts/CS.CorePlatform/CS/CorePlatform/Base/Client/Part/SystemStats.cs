using System.Collections.Generic;
using UnityEngine;

namespace CS.CorePlatform.Base.Client.Part
{
	public class SystemStats : MonoBehaviour
	{
		protected int _lastSize;

		protected object _locker;

		protected bool _dirty;

		protected bool _ready;

		protected BasePlatformManager _manager;

		protected Dictionary<string, float> _stats;

		public virtual void ClearStats(bool dirty = false)
		{
		}

		protected void ReadStats(byte[] data)
		{
		}

		protected void WriteStats()
		{
		}

		public virtual float GetStat(string key)
		{
			return 0f;
		}

		public virtual void SetStat(string key, float value)
		{
		}

		public virtual void AddStat(string key, float amount)
		{
		}
	}
}
