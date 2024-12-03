using UnityEngine;

namespace CS.CorePlatform.None.Client.Part
{
	public class NoneUtils : MonoBehaviour
	{
		private NonePlatformManager _manager;

		private bool _guiActive;

		public bool GUIActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void PlatformSystemMessenger_OnMessageChange(bool obj)
		{
		}
	}
}
